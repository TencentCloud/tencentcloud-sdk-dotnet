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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserMicStatus : AbstractModel
    {
        
        /// <summary>
        /// 开麦状态。1表示关闭麦克风，2表示打开麦克风。
        /// </summary>
        [JsonProperty("EnableMic")]
        public long? EnableMic{ get; set; }

        /// <summary>
        /// 客户端用于标识用户的Openid。（Uid、StrUid必须填一个，优先处理StrUid。）
        /// </summary>
        [JsonProperty("Uid")]
        public long? Uid{ get; set; }

        /// <summary>
        /// 客户端用于标识字符串型用户的Openid。（Uid、StrUid必须填一个，优先处理StrUid。）
        /// </summary>
        [JsonProperty("StrUid")]
        public string StrUid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableMic", this.EnableMic);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "StrUid", this.StrUid);
        }
    }
}

