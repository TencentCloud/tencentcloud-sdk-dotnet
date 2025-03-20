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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlDeviceRes : AbstractModel
    {
        
        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }

        /// <summary>
        /// 指令接受, 0表示成功
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 控制结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 批量大于1时，可用此seq进行链路追踪
        /// </summary>
        [JsonProperty("Seq")]
        public string Seq{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WID", this.WID);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
        }
    }
}

