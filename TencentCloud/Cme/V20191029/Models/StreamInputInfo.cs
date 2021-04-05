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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 流输入类型，取值：
        /// <li>VodPull ： 点播拉流；</li>
        /// <li>LivePull ：直播拉流；</li>
        /// <li>RtmpPush ： 直播推流。</li>
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 点播拉流信息，当 InputType = VodPull 时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VodPullInputInfo")]
        public VodPullInputInfo VodPullInputInfo{ get; set; }

        /// <summary>
        /// 直播拉流信息，当 InputType = LivePull  时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivePullInputInfo")]
        public LivePullInputInfo LivePullInputInfo{ get; set; }

        /// <summary>
        /// 直播推流信息，当 InputType = RtmpPush 时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RtmpPushInputInfo")]
        public RtmpPushInputInfo RtmpPushInputInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamObj(map, prefix + "VodPullInputInfo.", this.VodPullInputInfo);
            this.SetParamObj(map, prefix + "LivePullInputInfo.", this.LivePullInputInfo);
            this.SetParamObj(map, prefix + "RtmpPushInputInfo.", this.RtmpPushInputInfo);
        }
    }
}

