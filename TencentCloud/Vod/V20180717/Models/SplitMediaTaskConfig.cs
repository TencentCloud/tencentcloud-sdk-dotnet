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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SplitMediaTaskConfig : AbstractModel
    {
        
        /// <summary>
        /// 视频拆条起始的偏移时间，单位：秒。
        /// <li>不填或填0，表示转码后的视频从原始视频的起始位置开始；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频从原始视频的第 n 秒位置开始；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频从原始视频结束 n 秒前的位置开始。</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 视频拆条结束的偏移时间，单位：秒。
        /// <li>不填或填0，表示转码后的视频持续到原始视频的末尾终止；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频持续到原始视频第 n 秒时终止；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频持续到原始视频结束 n 秒前终止。</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// [任务流](https://cloud.tencent.com/document/product/266/33475#.E4.BB.BB.E5.8A.A1.E6.B5.81)名称。要对生成的新视频自动执行任务流时填写。
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// 视频拆条输出信息。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SplitMediaOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

