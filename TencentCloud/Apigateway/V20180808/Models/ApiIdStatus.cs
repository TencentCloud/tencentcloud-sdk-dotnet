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

    public class ApiIdStatus : AbstractModel
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
        /// API描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiDesc")]
        public string ApiDesc{ get; set; }

        /// <summary>
        /// API PATH。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// API METHOD。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 服务创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 服务修改时间。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// API名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// VPC唯一ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// API类型。
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
        /// 是否买后调试。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// 授权类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// API业务类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// 关联授权API唯一ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// 授权API关联的业务API列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationBuniessApiIds")]
        [System.Obsolete]
        public string[] RelationBuniessApiIds{ get; set; }

        /// <summary>
        /// oauth配置信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// oauth2.0API请求，token存放位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenLocation")]
        public string TokenLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiDesc", this.ApiDesc);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IsDebugAfterCharge", this.IsDebugAfterCharge);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ApiBusinessType", this.ApiBusinessType);
            this.SetParamSimple(map, prefix + "AuthRelationApiId", this.AuthRelationApiId);
            this.SetParamArraySimple(map, prefix + "RelationBuniessApiIds.", this.RelationBuniessApiIds);
            this.SetParamObj(map, prefix + "OauthConfig.", this.OauthConfig);
            this.SetParamSimple(map, prefix + "TokenLocation", this.TokenLocation);
        }
    }
}

