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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UebaUserSummary : AbstractModel
    {
        
        /// <summary>
        /// 全部用户数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllUserCount")]
        public ulong? AllUserCount{ get; set; }

        /// <summary>
        /// 异常用户数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbnormalUserCount")]
        public ulong? AbnormalUserCount{ get; set; }

        /// <summary>
        /// 云账号用户数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }

        /// <summary>
        /// 子用户数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUserCount")]
        public ulong? SubUserCount{ get; set; }

        /// <summary>
        /// 自定义用户数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomUserCount")]
        public ulong? CustomUserCount{ get; set; }

        /// <summary>
        /// 自定义用户求和组成元素
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Element")]
        public UebaUserSummaryElement[] Element{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllUserCount", this.AllUserCount);
            this.SetParamSimple(map, prefix + "AbnormalUserCount", this.AbnormalUserCount);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "SubUserCount", this.SubUserCount);
            this.SetParamSimple(map, prefix + "CustomUserCount", this.CustomUserCount);
            this.SetParamArrayObj(map, prefix + "Element.", this.Element);
        }
    }
}

