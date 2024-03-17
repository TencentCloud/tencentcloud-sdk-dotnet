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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVideoModerationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示策略的具体编号，用于接口调度，在[内容安全控制台](https://console.cloud.tencent.com/cms/clouds/manage)中可配置。若不传入Biztype参数（留空），则代表采用默认的识别策略；传入则会在审核时根据业务场景采取不同的审核策略。
        /// 备注：Biztype仅为数字、字母与下划线的组合，长度为3-32个字符；不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 任务类型：可选VIDEO（点播视频），LIVE_VIDEO（直播视频）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输入的任务信息，最多可以同时创建10个任务
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskInput[] Tasks{ get; set; }

        /// <summary>
        /// 验证签名参数，具体可以参考[验签说明](https://cloud.tencent.com/document/product/1265/104001#42dd87d2-580f-46cf-a953-639a787d1eda)。
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// 接收审核信息回调地址。如果设置了该字段，在审核过程中发现违规音频片段和画面截帧结果将发送至该接口。更多详情请参阅[回调配置说明](https://cloud.tencent.com/document/product/1265/104001)。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 审核排队优先级。当您有多个视频审核任务排队时，可以根据这个参数控制排队优先级。用于处理插队等逻辑。默认该参数为0
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的用户相关信息，若填入则可甄别相应违规风险用户
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamObj(map, prefix + "User.", this.User);
        }
    }
}

