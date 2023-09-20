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

    public class CreateFlowOption : AbstractModel
    {
        
        /// <summary>
        /// 是否允许修改发起合同时确认弹窗的合同信息（合同名称、合同类型、签署截止时间），若不允许编辑，则表单字段将被禁止输入。
        /// <br/>true：允许编辑<br/>false：不允许编辑（默认值）<br/>
        /// </summary>
        [JsonProperty("CanEditFlow")]
        public bool? CanEditFlow{ get; set; }

        /// <summary>
        /// 是否允许编辑模板控件
        /// <br/>true:允许编辑模板控件信息
        /// <br/>false:不允许编辑模板控件信息（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("CanEditFormField")]
        public bool? CanEditFormField{ get; set; }

        /// <summary>
        /// 发起页面隐藏合同名称展示
        /// <br/>true:发起页面隐藏合同名称展示
        /// <br/>false:发起页面不隐藏合同名称展示（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("HideShowFlowName")]
        public bool? HideShowFlowName{ get; set; }

        /// <summary>
        /// 发起页面隐藏合同类型展示
        /// <br/>true:发起页面隐藏合同类型展示
        /// <br/>false:发起页面不隐藏合同类型展示（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("HideShowFlowType")]
        public bool? HideShowFlowType{ get; set; }

        /// <summary>
        /// 发起页面隐藏合同截止日期展示
        /// <br/>true:发起页面隐藏合同截止日期展示
        /// <br/>false:发起页面不隐藏合同截止日期展示（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("HideShowDeadline")]
        public bool? HideShowDeadline{ get; set; }

        /// <summary>
        /// 发起页面允许跳过添加签署人环节
        /// <br/>true:发起页面允许跳过添加签署人环节
        /// <br/>false:发起页面不允许跳过添加签署人环节（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("CanSkipAddApprover")]
        public bool? CanSkipAddApprover{ get; set; }

        /// <summary>
        /// 文件发起页面跳过文件上传步骤
        /// <br/>true:文件发起页面跳过文件上传步骤
        /// <br/>false:文件发起页面不跳过文件上传步骤（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("SkipUploadFile")]
        public bool? SkipUploadFile{ get; set; }

        /// <summary>
        /// 禁止编辑填写控件
        /// <br/>true:禁止编辑填写控件
        /// <br/>false:允许编辑填写控件（默认值）
        /// <br/>
        /// </summary>
        [JsonProperty("ForbidEditFillComponent")]
        public bool? ForbidEditFillComponent{ get; set; }

        /// <summary>
        /// 定制化发起合同弹窗的描述信息，描述信息最长500字符
        /// </summary>
        [JsonProperty("CustomCreateFlowDescription")]
        public string CustomCreateFlowDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanEditFlow", this.CanEditFlow);
            this.SetParamSimple(map, prefix + "CanEditFormField", this.CanEditFormField);
            this.SetParamSimple(map, prefix + "HideShowFlowName", this.HideShowFlowName);
            this.SetParamSimple(map, prefix + "HideShowFlowType", this.HideShowFlowType);
            this.SetParamSimple(map, prefix + "HideShowDeadline", this.HideShowDeadline);
            this.SetParamSimple(map, prefix + "CanSkipAddApprover", this.CanSkipAddApprover);
            this.SetParamSimple(map, prefix + "SkipUploadFile", this.SkipUploadFile);
            this.SetParamSimple(map, prefix + "ForbidEditFillComponent", this.ForbidEditFillComponent);
            this.SetParamSimple(map, prefix + "CustomCreateFlowDescription", this.CustomCreateFlowDescription);
        }
    }
}

