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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWarningsRequest : AbstractModel
    {
        
        /// <summary>
        /// 1:创建时间倒序 2：创建时间升序 3：level倒序 4：leve升序
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 可选设备id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 如果不传则查询所有，取值参见配置
        /// </summary>
        [JsonProperty("WarnLevelArray")]
        public long?[] WarnLevelArray{ get; set; }

        /// <summary>
        /// 如果不传则查询所有，取值参见配置
        /// </summary>
        [JsonProperty("WarnModeArray")]
        public long?[] WarnModeArray{ get; set; }

        /// <summary>
        /// 不传认为是0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 不传认为是20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 形似：2021-05-21 00:00:00 .取值在当前日前30天内，不传默认是当前日前30天日期
        /// </summary>
        [JsonProperty("DateBegin")]
        public string DateBegin{ get; set; }

        /// <summary>
        /// 形似：2021-05-21 23:59:59 .取值在当前日前30天内，不传默认是当前日前30天日期
        /// </summary>
        [JsonProperty("DateEnd")]
        public string DateEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamArraySimple(map, prefix + "WarnLevelArray.", this.WarnLevelArray);
            this.SetParamArraySimple(map, prefix + "WarnModeArray.", this.WarnModeArray);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DateBegin", this.DateBegin);
            this.SetParamSimple(map, prefix + "DateEnd", this.DateEnd);
        }
    }
}

