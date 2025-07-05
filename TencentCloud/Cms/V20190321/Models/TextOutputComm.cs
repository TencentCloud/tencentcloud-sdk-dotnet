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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextOutputComm : AbstractModel
    {
        
        /// <summary>
        /// 接口唯一ID，旁路调用接口返回有该字段，标识唯一接口
        /// </summary>
        [JsonProperty("BUCtrlID")]
        public long? BUCtrlID{ get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [JsonProperty("SendTime")]
        public long? SendTime{ get; set; }

        /// <summary>
        /// 接入业务的唯一ID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 请求字段里的Common.Uin
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BUCtrlID", this.BUCtrlID);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

