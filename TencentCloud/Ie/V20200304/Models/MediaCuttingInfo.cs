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

    public class MediaCuttingInfo : AbstractModel
    {
        
        /// <summary>
        /// 截取时间信息。
        /// </summary>
        [JsonProperty("TimeInfo")]
        public MediaCuttingTimeInfo TimeInfo{ get; set; }

        /// <summary>
        /// 输出结果信息。
        /// </summary>
        [JsonProperty("TargetInfo")]
        public MediaTargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// 截取结果形式信息。
        /// </summary>
        [JsonProperty("OutForm")]
        public MediaCuttingOutForm OutForm{ get; set; }

        /// <summary>
        /// 列表文件形式，存储到用户存储服务中，可选值：
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
            this.SetParamObj(map, prefix + "TimeInfo.", this.TimeInfo);
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamObj(map, prefix + "OutForm.", this.OutForm);
            this.SetParamSimple(map, prefix + "ResultListSaveType", this.ResultListSaveType);
        }
    }
}

