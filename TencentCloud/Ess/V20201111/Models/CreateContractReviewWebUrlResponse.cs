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

    public class CreateContractReviewWebUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 接口返回的合同审查任务ID，可以调用接口<a href="https://qian.tencent.com/developers/companyApis/embedPages/DescribeContractReviewWebUrl" target="_blank">获取合同审查结果web页面</a>查看审查任务的结果。
        /// 
        /// 注意： `当ResourceId参数不为空时才会返回此值。`
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 合同审查嵌入式web页面链接。
        /// 
        /// 注意：`链接有效期为5分钟，且链接仅能使用一次。如果上传的合同文件为word时不能进行iframe方式嵌入到贵方系统的网页中，需要单独页面打开此链接显示`
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

