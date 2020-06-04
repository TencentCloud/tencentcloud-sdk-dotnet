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

    public class UsagePlanInfo : AbstractModel
    {
        
        /// <summary>
        /// 使用计划唯一 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanId")]
        public string UsagePlanId{ get; set; }

        /// <summary>
        /// 使用计划名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanName")]
        public string UsagePlanName{ get; set; }

        /// <summary>
        /// 使用计划描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanDesc")]
        public string UsagePlanDesc{ get; set; }

        /// <summary>
        /// 初始化调用次数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitQuota")]
        public long? InitQuota{ get; set; }

        /// <summary>
        /// 每秒请求限制数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRequestNumPreSec")]
        public long? MaxRequestNumPreSec{ get; set; }

        /// <summary>
        /// 最大调用次数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRequestNum")]
        public long? MaxRequestNum{ get; set; }

        /// <summary>
        /// 是否隐藏。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsHide")]
        public long? IsHide{ get; set; }

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
        /// 绑定密钥的数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindSecretIdTotalCount")]
        public long? BindSecretIdTotalCount{ get; set; }

        /// <summary>
        /// 绑定密钥的详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindSecretIds")]
        public string[] BindSecretIds{ get; set; }

        /// <summary>
        /// 绑定环境数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindEnvironmentTotalCount")]
        public long? BindEnvironmentTotalCount{ get; set; }

        /// <summary>
        /// 绑定环境详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindEnvironments")]
        public UsagePlanBindEnvironment[] BindEnvironments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsagePlanId", this.UsagePlanId);
            this.SetParamSimple(map, prefix + "UsagePlanName", this.UsagePlanName);
            this.SetParamSimple(map, prefix + "UsagePlanDesc", this.UsagePlanDesc);
            this.SetParamSimple(map, prefix + "InitQuota", this.InitQuota);
            this.SetParamSimple(map, prefix + "MaxRequestNumPreSec", this.MaxRequestNumPreSec);
            this.SetParamSimple(map, prefix + "MaxRequestNum", this.MaxRequestNum);
            this.SetParamSimple(map, prefix + "IsHide", this.IsHide);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "BindSecretIdTotalCount", this.BindSecretIdTotalCount);
            this.SetParamArraySimple(map, prefix + "BindSecretIds.", this.BindSecretIds);
            this.SetParamSimple(map, prefix + "BindEnvironmentTotalCount", this.BindEnvironmentTotalCount);
            this.SetParamArrayObj(map, prefix + "BindEnvironments.", this.BindEnvironments);
        }
    }
}

