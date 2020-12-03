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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// API ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 服务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceId")]
        public string MicroserviceId{ get; set; }

        /// <summary>
        /// 服务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroserviceName")]
        public string MicroserviceName{ get; set; }

        /// <summary>
        /// API 请求路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Api 映射路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathMapping")]
        public string PathMapping{ get; set; }

        /// <summary>
        /// 请求方法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 所属分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 是否禁用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsableStatus")]
        public string UsableStatus{ get; set; }

        /// <summary>
        /// 发布状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public string ReleaseStatus{ get; set; }

        /// <summary>
        /// 开启限流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RateLimitStatus")]
        public string RateLimitStatus{ get; set; }

        /// <summary>
        /// 是否开启mock
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MockStatus")]
        public string MockStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 发布时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReleasedTime")]
        public string ReleasedTime{ get; set; }

        /// <summary>
        /// 所属分组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// API 超时，单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Api所在服务host
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// API类型。 ms ： 微服务API； external :外部服务Api
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// Api描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "MicroserviceId", this.MicroserviceId);
            this.SetParamSimple(map, prefix + "MicroserviceName", this.MicroserviceName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "PathMapping", this.PathMapping);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "UsableStatus", this.UsableStatus);
            this.SetParamSimple(map, prefix + "ReleaseStatus", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "RateLimitStatus", this.RateLimitStatus);
            this.SetParamSimple(map, prefix + "MockStatus", this.MockStatus);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "ReleasedTime", this.ReleasedTime);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

