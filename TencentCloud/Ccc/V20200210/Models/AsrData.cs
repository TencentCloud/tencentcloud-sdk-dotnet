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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrData : AbstractModel
    {
        
        /// <summary>
        /// 用户方
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        [System.Obsolete]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 句子开始时间，Unix 毫秒时间戳
        /// </summary>
        [JsonProperty("Start")]
        public long? Start{ get; set; }

        /// <summary>
        /// 句子结束时间，Unix 毫秒时间戳
        /// </summary>
        [JsonProperty("End")]
        public long? End{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
        }
    }
}

