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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetUsageByDateRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要查询的业务类型名字列表
        /// - asr_rt 实时识别
        /// - asr_rec 录音文件识别
        /// </summary>
        [JsonProperty("BizNameList")]
        public string[] BizNameList{ get; set; }

        /// <summary>
        /// 查询开始时间
        /// 开始时间包含当天，支持 YYYY-MM-DD 日期以国内时区为准
        /// 开始时间到结束时间需要在3个月以内
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 查询结束时间
        /// 结束时间包含当天，，支持 YYYY-MM-DD 日期以国内时区为准
        /// 开始时间到结束时间需要在3个月以内
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BizNameList.", this.BizNameList);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
        }
    }
}

