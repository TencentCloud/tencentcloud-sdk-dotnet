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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecLogAlertMsgInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("MsgType")]
        public string MsgType{ get; set; }

        /// <summary>
        /// 告警值
        /// </summary>
        [JsonProperty("MsgValue")]
        public string MsgValue{ get; set; }

        /// <summary>
        /// 状态(0:关闭 1:开启)
        /// </summary>
        [JsonProperty("State")]
        public bool? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "MsgValue", this.MsgValue);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

