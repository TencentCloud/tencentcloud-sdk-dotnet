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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataServicePublishedApiDetailResp : AbstractModel
    {
        
        /// <summary>
        /// 服务Api名称
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// 服务请求Path
        /// </summary>
        [JsonProperty("PathUrl")]
        public string PathUrl{ get; set; }

        /// <summary>
        /// 服务责任人名称
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// 服务请求方式
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 服务标签名称集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiTagNames")]
        public string ApiTagNames{ get; set; }

        /// <summary>
        /// 服务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiDescription")]
        public string ApiDescription{ get; set; }

        /// <summary>
        /// 服务请求返回示例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestExample")]
        public string RequestExample{ get; set; }

        /// <summary>
        /// 服务请求成功返回示例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestSuccess")]
        public string RequestSuccess{ get; set; }

        /// <summary>
        /// 服务请求失败返回示例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestError")]
        public string RequestError{ get; set; }

        /// <summary>
        /// 服务请求参数列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParam")]
        public DataServiceRequestParam[] RequestParam{ get; set; }

        /// <summary>
        /// 服务响应参数列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseParam")]
        public DataServiceResponseParam[] ResponseParam{ get; set; }

        /// <summary>
        /// 最大qps
        /// </summary>
        [JsonProperty("MaxAllowQps")]
        public long? MaxAllowQps{ get; set; }

        /// <summary>
        /// 最大记录数
        /// </summary>
        [JsonProperty("MaxAllowPageSize")]
        public long? MaxAllowPageSize{ get; set; }

        /// <summary>
        /// 超时时间，单位ms
        /// </summary>
        [JsonProperty("TimeoutPeriod")]
        public ulong? TimeoutPeriod{ get; set; }

        /// <summary>
        /// ApiId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// 0:免认证 1:应用认证
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 请求地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayApiUrl")]
        public string GatewayApiUrl{ get; set; }

        /// <summary>
        /// 服务Api状态 1:已上线  3:已下线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiStatus")]
        public ulong? ApiStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "PathUrl", this.PathUrl);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "ApiTagNames", this.ApiTagNames);
            this.SetParamSimple(map, prefix + "ApiDescription", this.ApiDescription);
            this.SetParamSimple(map, prefix + "RequestExample", this.RequestExample);
            this.SetParamSimple(map, prefix + "RequestSuccess", this.RequestSuccess);
            this.SetParamSimple(map, prefix + "RequestError", this.RequestError);
            this.SetParamArrayObj(map, prefix + "RequestParam.", this.RequestParam);
            this.SetParamArrayObj(map, prefix + "ResponseParam.", this.ResponseParam);
            this.SetParamSimple(map, prefix + "MaxAllowQps", this.MaxAllowQps);
            this.SetParamSimple(map, prefix + "MaxAllowPageSize", this.MaxAllowPageSize);
            this.SetParamSimple(map, prefix + "TimeoutPeriod", this.TimeoutPeriod);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "GatewayApiUrl", this.GatewayApiUrl);
            this.SetParamSimple(map, prefix + "ApiStatus", this.ApiStatus);
        }
    }
}

