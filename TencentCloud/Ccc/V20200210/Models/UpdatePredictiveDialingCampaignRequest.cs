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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdatePredictiveDialingCampaignRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 生成的任务 ID
        /// </summary>
        [JsonProperty("CampaignId")]
        public long? CampaignId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 被叫列表，支持 E.164 或不带国家码形式的号码
        /// </summary>
        [JsonProperty("Callees")]
        public string[] Callees{ get; set; }

        /// <summary>
        /// 主叫列表，使用管理端展示的号码格式
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 被叫呼叫顺序 0 随机 1 顺序
        /// </summary>
        [JsonProperty("CallOrder")]
        public long? CallOrder{ get; set; }

        /// <summary>
        /// 使用的座席技能组 ID
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// 相同应用内多个任务运行优先级，从高到底 1 - 5
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 预期呼损率，百分比，5 - 50	
        /// </summary>
        [JsonProperty("ExpectedAbandonRate")]
        public long? ExpectedAbandonRate{ get; set; }

        /// <summary>
        /// 呼叫重试间隔时间，单位秒，60 - 86400
        /// </summary>
        [JsonProperty("RetryInterval")]
        public long? RetryInterval{ get; set; }

        /// <summary>
        /// 任务启动时间，Unix 时间戳，到此时间后会自动启动任务
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间，Unix 时间戳，到此时间后会自动终止任务
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 指定的 IVR ID
        /// </summary>
        [JsonProperty("IVRId")]
        public long? IVRId{ get; set; }

        /// <summary>
        /// 呼叫重试次数，0 - 2
        /// </summary>
        [JsonProperty("RetryTimes")]
        public long? RetryTimes{ get; set; }

        /// <summary>
        /// 自定义变量
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }

        /// <summary>
        /// 	UUI
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// 被叫属性
        /// </summary>
        [JsonProperty("CalleeAttributes")]
        public CalleeAttribute[] CalleeAttributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "CampaignId", this.CampaignId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Callees.", this.Callees);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "CallOrder", this.CallOrder);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "ExpectedAbandonRate", this.ExpectedAbandonRate);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IVRId", this.IVRId);
            this.SetParamSimple(map, prefix + "RetryTimes", this.RetryTimes);
            this.SetParamArrayObj(map, prefix + "Variables.", this.Variables);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "CalleeAttributes.", this.CalleeAttributes);
        }
    }
}

