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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTIWDailyUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// 互动白板应用SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 需要查询的子产品用量，支持传入以下值
        /// - sp_tiw_board: 互动白板时长，单位为分钟
        /// - sp_tiw_dt: 动态转码页数，单位页
        /// - sp_tiw_st: 静态转码页数，单位页
        /// - sp_tiw_ric: 实时录制时长，单位分钟
        /// 
        /// 注意：动态转码以1:8的比例计算文档转码页数，静态转码以1:1的比例计算文档转码页数
        /// </summary>
        [JsonProperty("SubProduct")]
        public string SubProduct{ get; set; }

        /// <summary>
        /// 开始时间，格式YYYY-MM-DD，查询结果里包括该天数据
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，格式YYYY-MM-DD，查询结果里包括该天数据，单次查询统计区间最多不能超过31天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SubProduct", this.SubProduct);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

