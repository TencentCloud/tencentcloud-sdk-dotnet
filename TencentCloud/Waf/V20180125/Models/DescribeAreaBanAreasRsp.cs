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

    public class DescribeAreaBanAreasRsp : AbstractModel
    {
        
        /// <summary>
        /// 状态 "0"：未开启地域封禁 "1"：开启地域封禁
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 数据来源 custom-自定义(默认)、batch-批量防护
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 字符串数据，配置的地域列表
        /// </summary>
        [JsonProperty("Areas")]
        public string[] Areas{ get; set; }

        /// <summary>
        /// 定时任务类型
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 定时任务详细配置
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }

        /// <summary>
        /// 周期任务配置
        /// </summary>
        [JsonProperty("CronType")]
        public string CronType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "Areas.", this.Areas);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
            this.SetParamSimple(map, prefix + "CronType", this.CronType);
        }
    }
}

