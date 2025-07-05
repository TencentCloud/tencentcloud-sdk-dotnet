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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthToken : AbstractModel
    {
        
        /// <summary>
        /// 认证Token
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 服务器时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentTime")]
        public long? CurrentTime{ get; set; }

        /// <summary>
        /// 毫秒时间戳，根据轮转周期准确计算得到
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextRotationTime")]
        public long? NextRotationTime{ get; set; }

        /// <summary>
        /// 毫秒，如果轮转失败则为 -1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastRotationTimeCost")]
        public long? LastRotationTimeCost{ get; set; }

        /// <summary>
        /// 成功：success
        /// 失败：failed
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotationStatus")]
        public string RotationStatus{ get; set; }

        /// <summary>
        /// 成功：success
        /// 失败：失败信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotationMessage")]
        public string RotationMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamSimple(map, prefix + "NextRotationTime", this.NextRotationTime);
            this.SetParamSimple(map, prefix + "LastRotationTimeCost", this.LastRotationTimeCost);
            this.SetParamSimple(map, prefix + "RotationStatus", this.RotationStatus);
            this.SetParamSimple(map, prefix + "RotationMessage", this.RotationMessage);
        }
    }
}

