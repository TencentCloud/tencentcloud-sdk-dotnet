/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DesApisStatus : AbstractModel
    {
        
        /// <summary>
        /// 服务唯一ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API唯一ID。
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// 用户自定义的 API 接口描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiDesc")]
        public string ApiDesc{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最后修改时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// API 接口的名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// VPCID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// VPC唯一ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// API类型。取值为NORMAL（普通API）和TSF（微服务API）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// API协议。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 是否买后调试。（云市场预留字段）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// API 鉴权类型。取值为SECRET（密钥对鉴权）、NONE（免鉴权）、OAUTH、EIAM。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// OAUTH API的类型。当AuthType 为 OAUTH时该字段有效， 取值为NORMAL（业务API）和 OAUTH（授权API）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// 关联的授权API 唯一 ID，当AuthType为OAUTH且ApiBusinessType为NORMAL时生效。标示业务API绑定的oauth2.0授权API唯一ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// OAUTH 配置信息。当AuthType是OAUTH时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// 授权API关联的业务API列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationBuniessApiIds")]
        [System.Obsolete]
        public string[] RelationBuniessApiIds{ get; set; }

        /// <summary>
        /// API关联的标签信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// API 的路径，如 /path。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// API 的请求方法，如 GET。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiDesc", this.ApiDesc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IsDebugAfterCharge", this.IsDebugAfterCharge);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ApiBusinessType", this.ApiBusinessType);
            this.SetParamSimple(map, prefix + "AuthRelationApiId", this.AuthRelationApiId);
            this.SetParamObj(map, prefix + "OauthConfig.", this.OauthConfig);
            this.SetParamArraySimple(map, prefix + "RelationBuniessApiIds.", this.RelationBuniessApiIds);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
        }
    }
}

