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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreateBatchCancelFlowUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 批量撤销合同的URL链接, 需要在手机端打开, 有效期24小时
        /// 
        /// 注：<font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("BatchCancelFlowUrl")]
        public string BatchCancelFlowUrl{ get; set; }

        /// <summary>
        /// 与入参的FlowIds数组一致,   成功生成到撤销链接中,则为"",   不能撤销合同则为失败原因
        /// </summary>
        [JsonProperty("FailMessages")]
        public string[] FailMessages{ get; set; }

        /// <summary>
        /// 签署撤销链接的过期时间(格式为:年-月-日 时:分:秒), 默认是生成链接的24小时后失效
        /// 
        /// </summary>
        [JsonProperty("UrlExpireOn")]
        public string UrlExpireOn{ get; set; }

        /// <summary>
        /// 批量撤销任务编号，为32位字符串，可用于[查询批量撤销合同结果](https://qian.tencent.com/developers/partnerApis/operateFlows/DescribeCancelFlowsTask) 或关联[批量撤销任务结果回调](https://qian.tencent.com/developers/partner/callback_types_contracts_sign#%E4%B9%9D-%E6%89%B9%E9%87%8F%E6%92%A4%E9%94%80%E7%BB%93%E6%9E%9C%E5%9B%9E%E8%B0%83)
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

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
            this.SetParamSimple(map, prefix + "BatchCancelFlowUrl", this.BatchCancelFlowUrl);
            this.SetParamArraySimple(map, prefix + "FailMessages.", this.FailMessages);
            this.SetParamSimple(map, prefix + "UrlExpireOn", this.UrlExpireOn);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

