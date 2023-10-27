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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskLogURLRequest : AbstractModel
    {
        
        /// <summary>
        /// 0: 预览， 1: 下载
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 任务报告Id 列表
        /// </summary>
        [JsonProperty("ReportItemKeyList")]
        public ReportItemKey[] ReportItemKeyList{ get; set; }

        /// <summary>
        /// 报告中任务id列表
        /// </summary>
        [JsonProperty("ReportTaskIdList")]
        public ReportTaskIdList[] ReportTaskIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "ReportItemKeyList.", this.ReportItemKeyList);
            this.SetParamArrayObj(map, prefix + "ReportTaskIdList.", this.ReportTaskIdList);
        }
    }
}

