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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserStore : AbstractModel
    {
        
        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 用户池logo
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserStoreLogo")]
        public string UserStoreLogo{ get; set; }

        /// <summary>
        /// 用户池描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserStoreDesc")]
        public string UserStoreDesc{ get; set; }

        /// <summary>
        /// 用户池名称
        /// </summary>
        [JsonProperty("UserStoreName")]
        public string UserStoreName{ get; set; }

        /// <summary>
        /// 用户数量
        /// </summary>
        [JsonProperty("UserNum")]
        public long? UserNum{ get; set; }

        /// <summary>
        /// 用户池ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// 应用数量
        /// </summary>
        [JsonProperty("AppNum")]
        public long? AppNum{ get; set; }

        /// <summary>
        /// 上次切换的用户池
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastStatus")]
        public bool? LastStatus{ get; set; }

        /// <summary>
        /// 默认用户池
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultStatus")]
        public bool? DefaultStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateDate")]
        public long? CreateDate{ get; set; }

        /// <summary>
        /// 上次切换时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastStatusTime")]
        public long? LastStatusTime{ get; set; }

        /// <summary>
        /// 用户目录域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserStoreProtocolHost")]
        public string UserStoreProtocolHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UserStoreLogo", this.UserStoreLogo);
            this.SetParamSimple(map, prefix + "UserStoreDesc", this.UserStoreDesc);
            this.SetParamSimple(map, prefix + "UserStoreName", this.UserStoreName);
            this.SetParamSimple(map, prefix + "UserNum", this.UserNum);
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "AppNum", this.AppNum);
            this.SetParamSimple(map, prefix + "LastStatus", this.LastStatus);
            this.SetParamSimple(map, prefix + "DefaultStatus", this.DefaultStatus);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "LastStatusTime", this.LastStatusTime);
            this.SetParamSimple(map, prefix + "UserStoreProtocolHost", this.UserStoreProtocolHost);
        }
    }
}

