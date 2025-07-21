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

    public class CommonApproverOption : AbstractModel
    {
        
        /// <summary>
        /// 是否允许修改签署人信息
        /// </summary>
        [JsonProperty("CanEditApprover")]
        public bool? CanEditApprover{ get; set; }

        /// <summary>
        /// 是否可以拒签 默认false-可以拒签 true-不可以拒签
        /// </summary>
        [JsonProperty("NoRefuse")]
        public bool? NoRefuse{ get; set; }

        /// <summary>
        /// 是否可以转发 默认false-可以转发 true-不可以转发
        /// </summary>
        [JsonProperty("NoTransfer")]
        public bool? NoTransfer{ get; set; }

        /// <summary>
        /// 当签署方有多个签署区时候，是否隐藏一键所有的签署区
        /// 
        /// false：（默认）不隐藏
        /// true：隐藏，每个签署区要单独选择印章或者签名
        /// </summary>
        [JsonProperty("HideOneKeySign")]
        public bool? HideOneKeySign{ get; set; }

        /// <summary>
        /// 签署人阅读合同限制参数
        ///  <br/>取值：
        /// <ul>
        /// <li> LimitReadTimeAndBottom，阅读合同必须限制阅读时长并且必须阅读到底</li>
        /// <li> LimitReadTime，阅读合同仅限制阅读时长</li>
        /// <li> LimitBottom，阅读合同仅限制必须阅读到底</li>
        /// <li> NoReadTimeAndBottom，阅读合同不限制阅读时长且不限制阅读到底（白名单功能，请联系客户经理开白使用）</li>
        /// </ul>
        /// </summary>
        [JsonProperty("FlowReadLimit")]
        public string FlowReadLimit{ get; set; }

        /// <summary>
        /// 禁止在签署过程中添加签署日期控件
        ///  <br/>前置条件：文件发起合同时，指定SignBeanTag=1（可以在签署过程中添加签署控件）：
        /// <ul>
        /// <li> 默认值：false，在开启：签署过程中添加签署控件时，添加签署控件会默认自带签署日期控件</li>
        /// <li> 可选值：true，在开启：签署过程中添加签署控件时，添加签署控件不会自带签署日期控件</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ForbidAddSignDate")]
        public bool? ForbidAddSignDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanEditApprover", this.CanEditApprover);
            this.SetParamSimple(map, prefix + "NoRefuse", this.NoRefuse);
            this.SetParamSimple(map, prefix + "NoTransfer", this.NoTransfer);
            this.SetParamSimple(map, prefix + "HideOneKeySign", this.HideOneKeySign);
            this.SetParamSimple(map, prefix + "FlowReadLimit", this.FlowReadLimit);
            this.SetParamSimple(map, prefix + "ForbidAddSignDate", this.ForbidAddSignDate);
        }
    }
}

