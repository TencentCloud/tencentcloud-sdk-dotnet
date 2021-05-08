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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStructCompareDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 主任务号
        /// </summary>
        [JsonProperty("MainTaskId")]
        public string MainTaskId{ get; set; }

        /// <summary>
        /// 子任务号
        /// </summary>
        [JsonProperty("SubTaskId")]
        public string SubTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MainTaskId", this.MainTaskId);
            this.SetParamSimple(map, prefix + "SubTaskId", this.SubTaskId);
        }
    }
}

