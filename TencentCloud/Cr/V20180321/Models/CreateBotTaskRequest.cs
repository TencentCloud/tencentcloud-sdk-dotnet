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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBotTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名。默认值（固定）：AiApi
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名。默认值（固定）：CreateTask
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 对话流ID
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 是否禁止拨打，默认Y
        /// </summary>
        [JsonProperty("BanCall")]
        public string BanCall{ get; set; }

        /// <summary>
        /// 拨打线路集合
        /// </summary>
        [JsonProperty("PhoneCollection")]
        public string PhoneCollection{ get; set; }

        /// <summary>
        /// 产品拨打时间集合
        /// </summary>
        [JsonProperty("CallTimeCollection")]
        public CallTimeDict CallTimeCollection{ get; set; }

        /// <summary>
        /// 禁止拨打起始时间。默认130000
        /// </summary>
        [JsonProperty("StartTimeBan")]
        public string StartTimeBan{ get; set; }

        /// <summary>
        /// 禁止拨打结束时间。默认140000
        /// </summary>
        [JsonProperty("EndTimeBan")]
        public string EndTimeBan{ get; set; }

        /// <summary>
        /// 重播方式，NON：未接通、LABEL：意向分级，可多选，用竖线分隔：NON|LABEL
        /// </summary>
        [JsonProperty("CodeType")]
        public string CodeType{ get; set; }

        /// <summary>
        /// 重播值集合，A：强意向、B：中意向、C：低意向、D：无意向、E：在忙、F：未接通、G：无效号码，可多选，用竖线分隔：A|B|C|D|E|F|G
        /// </summary>
        [JsonProperty("CodeCollection")]
        public string CodeCollection{ get; set; }

        /// <summary>
        /// 继续拨打次数
        /// </summary>
        [JsonProperty("CallCount")]
        public long? CallCount{ get; set; }

        /// <summary>
        /// 拨打间隔
        /// </summary>
        [JsonProperty("CallInterval")]
        public long? CallInterval{ get; set; }

        /// <summary>
        /// 未接通引用短信签名ID
        /// </summary>
        [JsonProperty("SmsSignId")]
        public string SmsSignId{ get; set; }

        /// <summary>
        /// 未接通引用短信模板ID
        /// </summary>
        [JsonProperty("SmsTemplateId")]
        public string SmsTemplateId{ get; set; }

        /// <summary>
        /// 拨打方式。NORMAL - 正常拨打；TIMER - 定时拨打
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// 拨打开始日期。CallType=TIMER时有值，yyyy-MM-dd
        /// </summary>
        [JsonProperty("CallStartDate")]
        public string CallStartDate{ get; set; }

        /// <summary>
        /// 拨打结束日期。CallType=PERIOD 时有值，yyyy-MM-dd
        /// </summary>
        [JsonProperty("CallEndDate")]
        public string CallEndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "BanCall", this.BanCall);
            this.SetParamSimple(map, prefix + "PhoneCollection", this.PhoneCollection);
            this.SetParamObj(map, prefix + "CallTimeCollection.", this.CallTimeCollection);
            this.SetParamSimple(map, prefix + "StartTimeBan", this.StartTimeBan);
            this.SetParamSimple(map, prefix + "EndTimeBan", this.EndTimeBan);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamSimple(map, prefix + "CodeCollection", this.CodeCollection);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "CallInterval", this.CallInterval);
            this.SetParamSimple(map, prefix + "SmsSignId", this.SmsSignId);
            this.SetParamSimple(map, prefix + "SmsTemplateId", this.SmsTemplateId);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "CallStartDate", this.CallStartDate);
            this.SetParamSimple(map, prefix + "CallEndDate", this.CallEndDate);
        }
    }
}

