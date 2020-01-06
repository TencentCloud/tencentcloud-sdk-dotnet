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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveTranscodeDetailInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 查询时间，北京时间，
        /// 格式：yyyymmdd。
        /// 注意：支持查询近3个月内某天的详细数据。
        /// </summary>
        [JsonProperty("DayTime")]
        public string DayTime{ get; set; }

        /// <summary>
        /// 页数，默认1，
        /// 不超过100页。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 每页个数，默认20，
        /// 范围：[10,1000]。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 起始天时间，北京时间，
        /// 格式：yyyymmdd。
        /// 注意：支持查询近3个月内的详细数据。
        /// </summary>
        [JsonProperty("StartDayTime")]
        public string StartDayTime{ get; set; }

        /// <summary>
        /// 结束天时间，北京时间，
        /// 格式：yyyymmdd。
        /// 注意：支持查询近3个月内的详细数据，注意DayTime 与（StartDayTime，EndDayTime）必须要传一个，如果都传，会以DayTime为准 。
        /// </summary>
        [JsonProperty("EndDayTime")]
        public string EndDayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "DayTime", this.DayTime);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "StartDayTime", this.StartDayTime);
            this.SetParamSimple(map, prefix + "EndDayTime", this.EndDayTime);
        }
    }
}

