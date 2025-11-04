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

    public class ApproverOption : AbstractModel
    {
        
        /// <summary>
        /// 签署方是否可以拒签
        /// 
        /// <ul><li> **false** : ( 默认)可以拒签</li>
        /// <li> **true** :不可以拒签</li></ul>
        /// </summary>
        [JsonProperty("NoRefuse")]
        public bool? NoRefuse{ get; set; }

        /// <summary>
        /// 签署方是否可以转他人处理
        /// 
        /// <ul><li> **false** : ( 默认)可以转他人处理</li>
        /// <li> **true** :不可以转他人处理</li></ul>
        /// </summary>
        [JsonProperty("NoTransfer")]
        public bool? NoTransfer{ get; set; }

        /// <summary>
        /// 允许编辑签署人信息（嵌入式使用） 默认true-可以编辑 false-不可以编辑
        /// </summary>
        [JsonProperty("CanEditApprover")]
        public bool? CanEditApprover{ get; set; }

        /// <summary>
        /// 签署人信息补充类型，默认无需补充。
        /// 
        /// <ul><li> **1** :  动态签署人（可发起合同后再补充签署人信息）注：`企业自动签不支持动态补充`</li></ul>
        /// 
        /// 
        /// 
        /// 注：
        /// 1. `使用动态签署人能力前，需登录腾讯电子签控制台打开服务开关`
        /// 2. 此参数在嵌入式场景下无效。
        /// </summary>
        [JsonProperty("FillType")]
        public long? FillType{ get; set; }

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
            this.SetParamSimple(map, prefix + "NoRefuse", this.NoRefuse);
            this.SetParamSimple(map, prefix + "NoTransfer", this.NoTransfer);
            this.SetParamSimple(map, prefix + "CanEditApprover", this.CanEditApprover);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "FlowReadLimit", this.FlowReadLimit);
            this.SetParamSimple(map, prefix + "ForbidAddSignDate", this.ForbidAddSignDate);
        }
    }
}

