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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSDefendStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 防护状态，为0表示防护处于关闭状态，为1表示防护处于开启状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefendStatus")]
        public ulong? DefendStatus{ get; set; }

        /// <summary>
        /// 防护临时关闭的过期时间，当防护状态为开启时此字段为空；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UndefendExpire")]
        public string UndefendExpire{ get; set; }

        /// <summary>
        /// 控制台功能展示字段，为1表示控制台功能展示，为0表示控制台功能隐藏
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowFlag")]
        public ulong? ShowFlag{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "UndefendExpire", this.UndefendExpire);
            this.SetParamSimple(map, prefix + "ShowFlag", this.ShowFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

