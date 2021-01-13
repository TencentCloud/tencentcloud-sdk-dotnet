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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryRecordListRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名。AiApi
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名。QueryRecordList
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 偏移值
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 偏移位移，最大20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 任务ID，二者必填一个
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 任务名称，二者必填一个
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("CalledPhone")]
        public string CalledPhone{ get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonProperty("StartBizDate")]
        public string StartBizDate{ get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [JsonProperty("EndBizDate")]
        public string EndBizDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
            this.SetParamSimple(map, prefix + "CalledPhone", this.CalledPhone);
            this.SetParamSimple(map, prefix + "StartBizDate", this.StartBizDate);
            this.SetParamSimple(map, prefix + "EndBizDate", this.EndBizDate);
        }
    }
}

