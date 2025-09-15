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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInformationExtractionTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 合同信息提取字段信息
        /// </summary>
        [JsonProperty("Fields")]
        public ExtractionField[] Fields{ get; set; }

        /// <summary>
        /// 合同智能提取任务状态。
        /// 状态如下：
        /// <ul>
        ///     <li>**0** - 任务创建成功（还未执行）</li> 
        ///     <li>**1** - 排队中（等待执行）</li>   
        ///     <li>**2** - 提取中（正在执行）</li>  
        ///     <li>**3** - 提取成功</li>   
        ///     <li>**4** - 提取失败</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 合同智能提取结果下载，文件格式为`xlsx`。
        /// 
        /// 注意：`链接有效期为5分钟，过期后可重新获取`
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 合同信息提取结果信息
        /// </summary>
        [JsonProperty("Results")]
        public ExtractionTaskResult[] Results{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

