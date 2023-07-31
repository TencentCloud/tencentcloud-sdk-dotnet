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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBatchCancelFlowUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 批量撤回签署流程链接
        /// </summary>
        [JsonProperty("BatchCancelFlowUrl")]
        public string BatchCancelFlowUrl{ get; set; }

        /// <summary>
        /// 签署流程撤回失败信息
        /// 数组里边的错误原因与传进来的FlowIds一一对应,如果是空字符串则标识没有出错
        /// </summary>
        [JsonProperty("FailMessages")]
        public string[] FailMessages{ get; set; }

        /// <summary>
        /// 签署连接过期时间字符串：年月日-时分秒
        /// 
        /// 例如:2023-07-28 17:25:59
        /// </summary>
        [JsonProperty("UrlExpireOn")]
        public string UrlExpireOn{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchCancelFlowUrl", this.BatchCancelFlowUrl);
            this.SetParamArraySimple(map, prefix + "FailMessages.", this.FailMessages);
            this.SetParamSimple(map, prefix + "UrlExpireOn", this.UrlExpireOn);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

