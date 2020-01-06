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

    public class DescribeGroupProIspPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间点，格式为yyyy-mm-dd HH:MM:SS。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间点，格式为yyyy-mm-dd HH:MM:SS
        /// 时间跨度在（0,3小时]，支持最近1个月数据查询。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 播放域名，默认为不填，表示求总体数据。
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// 省份列表，默认不填，则返回各省份的数据。
        /// </summary>
        [JsonProperty("ProvinceNames")]
        public string[] ProvinceNames{ get; set; }

        /// <summary>
        /// 运营商列表，默认不填，则返回个运营商的数据。
        /// </summary>
        [JsonProperty("IspNames")]
        public string[] IspNames{ get; set; }

        /// <summary>
        /// 国内还是国外，如果为空，查询所有地区数据；如果为“Mainland”，查询国内数据；如果为“Oversea”，则查询国外数据。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamArraySimple(map, prefix + "ProvinceNames.", this.ProvinceNames);
            this.SetParamArraySimple(map, prefix + "IspNames.", this.IspNames);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
        }
    }
}

