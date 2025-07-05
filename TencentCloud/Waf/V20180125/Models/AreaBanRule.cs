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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AreaBanRule : AbstractModel
    {
        
        /// <summary>
        /// 状态 0：未开启地域封禁、1：开启地域封禁
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 数据来源 custom：自定义(默认)、batch：批量防护
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 配置的地域列表
        /// </summary>
        [JsonProperty("Areas")]
        public Area[] Areas{ get; set; }

        /// <summary>
        /// 规则执行的方式，TimedJob为定时执行，CronJob为周期执行
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 定时任务配置
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }

        /// <summary>
        /// 如果是周期任务类型，那么表示周期的类型，支持 Week：按周、Month：按月
        /// </summary>
        [JsonProperty("CronType")]
        public string CronType{ get; set; }

        /// <summary>
        /// 地域信息的语言，支持cn、en，默认为中文cn
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArrayObj(map, prefix + "Areas.", this.Areas);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
            this.SetParamSimple(map, prefix + "CronType", this.CronType);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
        }
    }
}

