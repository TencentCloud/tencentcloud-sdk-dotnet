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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaTargetInfo : AbstractModel
    {
        
        /// <summary>
        /// 目标文件名，不能带特殊字符（如/等），无需后缀名，最长200字符。
        /// 
        /// 注1：部分子服务支持占位符，形式为： {parameter}
        /// 预设parameter有：
        /// index：序号；
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 媒体封装格式，最长5字符，具体格式支持根据子任务确定。
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 视频流信息。
        /// </summary>
        [JsonProperty("TargetVideoInfo")]
        public TargetVideoInfo TargetVideoInfo{ get; set; }

        /// <summary>
        /// 【不再使用】 对于多输出任务，部分子服务推荐结果信息以列表文件形式，存储到用户存储服务中，可选值：
        /// UseSaveInfo：默认，结果列表和结果存储同一位置；
        /// NoListFile：不存储结果列表。
        /// </summary>
        [JsonProperty("ResultListSaveType")]
        public string ResultListSaveType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamObj(map, prefix + "TargetVideoInfo.", this.TargetVideoInfo);
            this.SetParamSimple(map, prefix + "ResultListSaveType", this.ResultListSaveType);
        }
    }
}

