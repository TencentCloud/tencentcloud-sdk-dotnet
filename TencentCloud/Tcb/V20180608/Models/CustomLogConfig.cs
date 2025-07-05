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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomLogConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否需要请求体
        /// </summary>
        [JsonProperty("NeedReqBodyLog")]
        public bool? NeedReqBodyLog{ get; set; }

        /// <summary>
        /// 是否需要请求头
        /// </summary>
        [JsonProperty("NeedReqHeaderLog")]
        public bool? NeedReqHeaderLog{ get; set; }

        /// <summary>
        /// 是否需要回包体
        /// </summary>
        [JsonProperty("NeedRspBodyLog")]
        public bool? NeedRspBodyLog{ get; set; }

        /// <summary>
        /// 是否需要回包头部信息
        /// </summary>
        [JsonProperty("NeedRspHeaderLog")]
        public bool? NeedRspHeaderLog{ get; set; }

        /// <summary>
        /// cls set信息
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// cls topicId
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NeedReqBodyLog", this.NeedReqBodyLog);
            this.SetParamSimple(map, prefix + "NeedReqHeaderLog", this.NeedReqHeaderLog);
            this.SetParamSimple(map, prefix + "NeedRspBodyLog", this.NeedRspBodyLog);
            this.SetParamSimple(map, prefix + "NeedRspHeaderLog", this.NeedRspHeaderLog);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
        }
    }
}

