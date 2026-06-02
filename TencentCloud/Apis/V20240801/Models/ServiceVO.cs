/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceVO : AbstractModel
    {
        
        /// <summary>
        /// <p>实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>里约应用ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaasID")]
        [System.Obsolete]
        public string PaasID{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelIDs")]
        public string[] LabelIDs{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryIDs")]
        public string[] CategoryIDs{ get; set; }

        /// <summary>
        /// <p>鉴权方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthType")]
        [System.Obsolete]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>签名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignType")]
        [System.Obsolete]
        public string SignType{ get; set; }

        /// <summary>
        /// <p>登录方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoginTypes")]
        [System.Obsolete]
        public string[] LoginTypes{ get; set; }

        /// <summary>
        /// <p>负载方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// <p>公开路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PubPath")]
        public string PubPath{ get; set; }

        /// <summary>
        /// <p>请求方法</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestMethod")]
        public string RequestMethod{ get; set; }

        /// <summary>
        /// <p>目标服务器</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// <p>是否https</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// <p>证书检查</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// <p>http协议类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpProtocolVersion")]
        public string HttpProtocolVersion{ get; set; }

        /// <summary>
        /// <p>版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Versions")]
        public VersionDTO[] Versions{ get; set; }

        /// <summary>
        /// <p>目标路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// <p>入参</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParamsValidatorStatus")]
        public bool? RequestParamsValidatorStatus{ get; set; }

        /// <summary>
        /// <p>入参</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParamsValidatorJsonInfoT")]
        public string RequestParamsValidatorJsonInfoT{ get; set; }

        /// <summary>
        /// <p>出参</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseParamsValidatorStatus")]
        public bool? ResponseParamsValidatorStatus{ get; set; }

        /// <summary>
        /// <p>出参</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseParamsValidatorJsonInfoT")]
        public string ResponseParamsValidatorJsonInfoT{ get; set; }

        /// <summary>
        /// <p>流量控制</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// <p>流量控制</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// <p>健康检查</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckStatus")]
        public bool? HealthCheckStatus{ get; set; }

        /// <summary>
        /// <p>健康检查</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfigDTO HealthCheckConfig{ get; set; }

        /// <summary>
        /// <p>格式转换</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceTypeStatus")]
        public bool? SourceTypeStatus{ get; set; }

        /// <summary>
        /// <p>格式转换</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceTypeConfig")]
        public SourceTypeConfigDTO SourceTypeConfig{ get; set; }

        /// <summary>
        /// <p>是否开启Token限流</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenLimitStatus")]
        [System.Obsolete]
        public bool? TokenLimitStatus{ get; set; }

        /// <summary>
        /// <p>Token限流配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenLimitConfig")]
        [System.Obsolete]
        public TokenLimitConfigDTO TokenLimitConfig{ get; set; }

        /// <summary>
        /// <p>是否开启内容安全</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TmsStatus")]
        [System.Obsolete]
        public bool? TmsStatus{ get; set; }

        /// <summary>
        /// <p>内容安全配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TmsConfig")]
        [System.Obsolete]
        public TmsConfigDTO TmsConfig{ get; set; }

        /// <summary>
        /// <p>IP白名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// <p>IP白名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// <p>IP黑名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// <p>IP黑名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// <p>插件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// <p>服务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>预览地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>app</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("App")]
        public IDNameVO App{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalogs")]
        public IDNameVO[] Catalogs{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public IDNameVO[] Labels{ get; set; }

        /// <summary>
        /// <p>认证方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Logins")]
        public IDNameVO[] Logins{ get; set; }

        /// <summary>
        /// <p>授权数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthAppNum")]
        public long? AuthAppNum{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>是否开启报文记录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenMessageLogStatus")]
        public bool? OpenMessageLogStatus{ get; set; }

        /// <summary>
        /// <p>订阅页面的当前用户是否订阅了该API</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrPaasIDSubscriptionID")]
        [System.Obsolete]
        public string CurrPaasIDSubscriptionID{ get; set; }

        /// <summary>
        /// <p>目标服务类型 Restful Database Mock</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// <p>SQL模板</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public SqlTemplate SqlTemplate{ get; set; }

        /// <summary>
        /// <p>目标Host类型 0 默认 1 vpc</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHostType")]
        public long? TargetHostType{ get; set; }

        /// <summary>
        /// <p>后端服务类型 0 自定义 原始数据:ip/域名或vpc 1 后端服务 服务组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceHostType")]
        public ulong? TargetServiceHostType{ get; set; }

        /// <summary>
        /// <p>后端服务组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServerGroupID")]
        public string TargetServerGroupID{ get; set; }

        /// <summary>
        /// <p>后端服务组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServerGroup")]
        public TargetServerGroupDTO TargetServerGroup{ get; set; }

        /// <summary>
        /// <p>自定义host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomHttpHost")]
        public string CustomHttpHost{ get; set; }

        /// <summary>
        /// <p>Http 请求host类型 useRequestHost 保持源请求host targetHost 修正为源站host  customHost 自定义host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpHostType")]
        public string HttpHostType{ get; set; }

        /// <summary>
        /// <p>mock响应状态码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MockStatusCode")]
        public long? MockStatusCode{ get; set; }

        /// <summary>
        /// <p>mock响应body</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MockBody")]
        public string MockBody{ get; set; }

        /// <summary>
        /// <p>mock响应头</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MockHeaders")]
        public FieldValueDTO[] MockHeaders{ get; set; }

        /// <summary>
        /// <p>路径匹配类型: prefix 前缀匹配(不送默认); absolute 绝对匹配; regex正则匹配;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathMatchType")]
        public string PathMatchType{ get; set; }

        /// <summary>
        /// <p>自定义匹配条件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomMatch")]
        public CustomMatch CustomMatch{ get; set; }

        /// <summary>
        /// <p>请求的超时时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>绑定的mcp server数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("McpServerNum")]
        public long? McpServerNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PaasID", this.PaasID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "LabelIDs.", this.LabelIDs);
            this.SetParamArraySimple(map, prefix + "CategoryIDs.", this.CategoryIDs);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamArraySimple(map, prefix + "LoginTypes.", this.LoginTypes);
            this.SetParamSimple(map, prefix + "TargetSelect", this.TargetSelect);
            this.SetParamSimple(map, prefix + "PubPath", this.PubPath);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamArrayObj(map, prefix + "TargetHosts.", this.TargetHosts);
            this.SetParamSimple(map, prefix + "HttpProtocolType", this.HttpProtocolType);
            this.SetParamSimple(map, prefix + "CheckTargetCertsError", this.CheckTargetCertsError);
            this.SetParamSimple(map, prefix + "HttpProtocolVersion", this.HttpProtocolVersion);
            this.SetParamArrayObj(map, prefix + "Versions.", this.Versions);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamSimple(map, prefix + "RequestParamsValidatorStatus", this.RequestParamsValidatorStatus);
            this.SetParamSimple(map, prefix + "RequestParamsValidatorJsonInfoT", this.RequestParamsValidatorJsonInfoT);
            this.SetParamSimple(map, prefix + "ResponseParamsValidatorStatus", this.ResponseParamsValidatorStatus);
            this.SetParamSimple(map, prefix + "ResponseParamsValidatorJsonInfoT", this.ResponseParamsValidatorJsonInfoT);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamSimple(map, prefix + "HealthCheckStatus", this.HealthCheckStatus);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "SourceTypeStatus", this.SourceTypeStatus);
            this.SetParamObj(map, prefix + "SourceTypeConfig.", this.SourceTypeConfig);
            this.SetParamSimple(map, prefix + "TokenLimitStatus", this.TokenLimitStatus);
            this.SetParamObj(map, prefix + "TokenLimitConfig.", this.TokenLimitConfig);
            this.SetParamSimple(map, prefix + "TmsStatus", this.TmsStatus);
            this.SetParamObj(map, prefix + "TmsConfig.", this.TmsConfig);
            this.SetParamSimple(map, prefix + "IpWhiteStatus", this.IpWhiteStatus);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "IpBlackStatus", this.IpBlackStatus);
            this.SetParamArraySimple(map, prefix + "IpBlackList.", this.IpBlackList);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "App.", this.App);
            this.SetParamArrayObj(map, prefix + "Catalogs.", this.Catalogs);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Logins.", this.Logins);
            this.SetParamSimple(map, prefix + "AuthAppNum", this.AuthAppNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "OpenMessageLogStatus", this.OpenMessageLogStatus);
            this.SetParamSimple(map, prefix + "CurrPaasIDSubscriptionID", this.CurrPaasIDSubscriptionID);
            this.SetParamSimple(map, prefix + "TargetServiceType", this.TargetServiceType);
            this.SetParamObj(map, prefix + "SqlTemplate.", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "TargetHostType", this.TargetHostType);
            this.SetParamSimple(map, prefix + "TargetServiceHostType", this.TargetServiceHostType);
            this.SetParamSimple(map, prefix + "TargetServerGroupID", this.TargetServerGroupID);
            this.SetParamObj(map, prefix + "TargetServerGroup.", this.TargetServerGroup);
            this.SetParamSimple(map, prefix + "CustomHttpHost", this.CustomHttpHost);
            this.SetParamSimple(map, prefix + "HttpHostType", this.HttpHostType);
            this.SetParamSimple(map, prefix + "MockStatusCode", this.MockStatusCode);
            this.SetParamSimple(map, prefix + "MockBody", this.MockBody);
            this.SetParamArrayObj(map, prefix + "MockHeaders.", this.MockHeaders);
            this.SetParamSimple(map, prefix + "PathMatchType", this.PathMatchType);
            this.SetParamObj(map, prefix + "CustomMatch.", this.CustomMatch);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "McpServerNum", this.McpServerNum);
        }
    }
}

