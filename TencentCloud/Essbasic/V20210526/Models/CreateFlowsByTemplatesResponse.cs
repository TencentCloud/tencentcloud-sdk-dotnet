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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowsByTemplatesResponse : AbstractModel
    {
        
        /// <summary>
        /// 多个合同ID
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 渠道的业务信息，限制1024字符
        /// </summary>
        [JsonProperty("CustomerData")]
        public string[] CustomerData{ get; set; }

        /// <summary>
        /// 创建消息，对应多个合同ID，
        /// 成功为“”,创建失败则对应失败消息
        /// </summary>
        [JsonProperty("ErrorMessages")]
        public string[] ErrorMessages{ get; set; }

        /// <summary>
        /// 预览模式下返回的预览文件url数组
        /// </summary>
        [JsonProperty("PreviewUrls")]
        public string[] PreviewUrls{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamArraySimple(map, prefix + "CustomerData.", this.CustomerData);
            this.SetParamArraySimple(map, prefix + "ErrorMessages.", this.ErrorMessages);
            this.SetParamArraySimple(map, prefix + "PreviewUrls.", this.PreviewUrls);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

