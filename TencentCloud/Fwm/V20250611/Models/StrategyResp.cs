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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyResp : AbstractModel
    {
        
        /// <summary>
        /// 策略Id
        /// </summary>
        [JsonProperty("StrategyId")]
        public string StrategyId{ get; set; }

        /// <summary>
        /// 规则组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 规则组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 规则数
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// 策略状态
        /// </summary>
        [JsonProperty("RuleStatus")]
        public long? RuleStatus{ get; set; }

        /// <summary>
        /// 下发账号
        /// </summary>
        [JsonProperty("ReceiveAccount")]
        public ReceiveAccount[] ReceiveAccount{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Sequence")]
        public long? Sequence{ get; set; }

        /// <summary>
        /// 下发失败原因
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 下发失败原因类型
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("UpdateBy")]
        public string UpdateBy{ get; set; }

        /// <summary>
        /// 执行区域
        /// </summary>
        [JsonProperty("ExecArea")]
        public string ExecArea{ get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("CreateName")]
        public string CreateName{ get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [JsonProperty("UpdateName")]
        public string UpdateName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "ReceiveAccount.", this.ReceiveAccount);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "UpdateBy", this.UpdateBy);
            this.SetParamSimple(map, prefix + "ExecArea", this.ExecArea);
            this.SetParamSimple(map, prefix + "CreateName", this.CreateName);
            this.SetParamSimple(map, prefix + "UpdateName", this.UpdateName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

