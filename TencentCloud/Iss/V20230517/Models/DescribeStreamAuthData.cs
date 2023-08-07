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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamAuthData : AbstractModel
    {
        
        /// <summary>
        /// 鉴权配置ID（uuid）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 是否开播放鉴权（1:开启,0:关闭）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullState")]
        public long? PullState{ get; set; }

        /// <summary>
        /// 播放密钥（仅支持字母数字，长度0-10位）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullSecret")]
        public string PullSecret{ get; set; }

        /// <summary>
        /// 播放过期时间（单位：分钟）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullExpired")]
        public long? PullExpired{ get; set; }

        /// <summary>
        /// 是否开启推流鉴权（1:开启,0:关闭）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PushState")]
        public long? PushState{ get; set; }

        /// <summary>
        /// 推流密钥（仅支持字母数字，长度0-10位）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PushSecret")]
        public string PushSecret{ get; set; }

        /// <summary>
        /// 推流过期时间（单位：分钟）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PushExpired")]
        public long? PushExpired{ get; set; }

        /// <summary>
        /// 用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PullState", this.PullState);
            this.SetParamSimple(map, prefix + "PullSecret", this.PullSecret);
            this.SetParamSimple(map, prefix + "PullExpired", this.PullExpired);
            this.SetParamSimple(map, prefix + "PushState", this.PushState);
            this.SetParamSimple(map, prefix + "PushSecret", this.PushSecret);
            this.SetParamSimple(map, prefix + "PushExpired", this.PushExpired);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

