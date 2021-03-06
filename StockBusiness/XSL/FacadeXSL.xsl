<xsl:transform
        version="1.0"
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:myCustDate="urn:custDate">
<xsl:output method="text" omit-xml-declaration="yes" />		
<xsl:template name="DataType">
	<xsl:param name="x"/>
	<xsl:if test="dataType[.='varchar']">string </xsl:if>
	<xsl:if test="dataType[.='char']">string </xsl:if>
	<xsl:if test="dataType[.='nvarchar']">string </xsl:if>
	<xsl:if test="dataType[.='ntext']">string </xsl:if>	
	<xsl:if test="dataType[.='int']">int </xsl:if>
	<xsl:if test="dataType[.='float']">double </xsl:if>
	<xsl:if test="dataType[.='double']">double </xsl:if>
	<xsl:if test="dataType[.='decimal']">Decimal </xsl:if>	
	<xsl:if test="dataType[.='datetime']">DateTime </xsl:if>
	<xsl:if test="dataType[.='bit']">Byte </xsl:if>
	<xsl:if test="dataType[.='bigint']">long </xsl:if>
</xsl:template>
<xsl:template name="initCap">
  <xsl:param name="x"/>
  <xsl:value-of select="translate(substring($x,1,1),'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
  <xsl:value-of select="substring($x,2)"/>
</xsl:template>
<xsl:template match="Table">
<!--
<xsl:value-of select="substring(./name, 0, string-length(./name)-1)"/>
-->
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	<xsl:variable name="tableName" select="./name"/>
	public class <xsl:value-of select="./name"/>Facade : BaseFacade
	{
		protected static <xsl:value-of select="./name"/>Facade instance = new <xsl:value-of select="./name"/>Facade(new <xsl:value-of select="./name"/>Model());
		protected <xsl:value-of select="./name"/>Facade(<xsl:value-of select="./name"/>Model model) : base(model)
		{
		}
		public static <xsl:value-of select="./name"/>Facade Instance
		{
			get { return instance; }
		}
		protected <xsl:value-of select="./name"/>Facade():base() 
		{ 
		} 
	<xsl:for-each select="/Table/column">
		<xsl:if test="isFK[.='true']">
		public ArrayList FindBy<xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template>(<xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:value-of select="./name"/>)
		{
			return FindByAttribute("<xsl:value-of select="./name"/>", <xsl:value-of select="./name"/>);
		}
		</xsl:if>
		<xsl:if test="isUnique[.='true']">
		public <xsl:value-of select="$tableName"/>Model FindBy<xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template>(<xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:value-of select="./name"/>)
		{
			return (<xsl:value-of select="$tableName"/>Model) FindByUK("<xsl:value-of select="./name"/>", <xsl:value-of select="./name"/>);
		}
		</xsl:if>
	</xsl:for-each>
	}
}
	</xsl:template>
</xsl:transform>		
