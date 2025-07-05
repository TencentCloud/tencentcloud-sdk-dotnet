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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchTraceRequest : AbstractModel
    {
        
        /// <summary>
        /// 希望搜索的人体库ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 人体动作轨迹信息。
        /// </summary>
        [JsonProperty("Trace")]
        public Trace Trace{ get; set; }

        /// <summary>
        /// 单张被识别的人体动作轨迹返回的最相似人员数量。
        /// 默认值为5，最大值为100。
        ///  例，设MaxPersonNum为8，则返回Top8相似的人员信息。 值越大，需要处理的时间越长。建议不要超过10。
        /// </summary>
        [JsonProperty("MaxPersonNum")]
        public ulong? MaxPersonNum{ get; set; }

        /// <summary>
        /// 出参Score中，只有超过TraceMatchThreshold值的结果才会返回。
        /// 默认为0。范围[0, 100.0]。
        /// </summary>
        [JsonProperty("TraceMatchThreshold")]
        public float? TraceMatchThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamObj(map, prefix + "Trace.", this.Trace);
            this.SetParamSimple(map, prefix + "MaxPersonNum", this.MaxPersonNum);
            this.SetParamSimple(map, prefix + "TraceMatchThreshold", this.TraceMatchThreshold);
        }
    }
}

