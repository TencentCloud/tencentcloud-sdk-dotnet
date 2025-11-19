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
        ///  禁止添加签署方，若为true则在发起流程的可嵌入页面隐藏“添加签署人按钮”
        /// </summary>
        [JsonProperty("ForbidAddApprover")]
        public bool? ForbidAddApprover{ get; set; }

        /// <summary>
        /// 是否可以编辑签署人包括新增，修改，删除 
        /// <ul><li>（默认） false -可以编辑签署人</li> <li> true - 禁止编辑签署人</li></ul>
        /// 
        /// 注意：如果设置参数为  true， 则 参数签署人 [FlowApproverList](https://qian.tencent.com/developers/partnerApis/embedPages/ChannelCreatePrepareFlow) 不能为空
        /// </summary>
        [JsonProperty("ForbidEditApprover")]
        public bool? ForbidEditApprover{ get; set; }

        /// <summary>
        ///   禁止设置签署流程属性 (顺序、合同签署认证方式等)，若为true则在发起流程的可嵌入页面隐藏签署流程设置面板
        /// </summary>
        [JsonProperty("ForbidEditFlowProperties")]
        public bool? ForbidEditFlowProperties{ get; set; }

        /// <summary>
        /// 在发起流程的可嵌入页面要隐藏的控件列表，和 ShowComponentTypes 参数 只能二选一使用（注: 
        /// <font color='red'>空数组代表未指定</font>），具体的控件类型如下
        /// 
        /// <ul><li>SIGN_SIGNATURE : 个人签名/印章</li>
        /// <li>SIGN_SEAL : 企业印章</li>
        /// <li>SIGN_PAGING_SEAL : 骑缝章</li>
        /// <li>SIGN_LEGAL_PERSON_SEAL : 法定代表人章</li>
        /// <li>SIGN_APPROVE : 签批</li>
        /// <li>SIGN_OPINION : 签署意见</li>
        /// <li>SIGN_PAGING_SIGNATURE : 手写签名骑缝控件</li>
        /// <li>BUSI-FULL-NAME  : 企业全称</li>
        /// <li>BUSI-CREDIT-CODE : 统一社会信用代码</li>
        /// <li>BUSI-LEGAL-NAME : 法人/经营者姓名</li>
        /// <li>PERSONAL-NAME : 签署人姓名</li>
        /// <li>PERSONAL-MOBILE : 签署人手机号</li>
        /// <li>PERSONAL-IDCARD-TYPE : 签署人证件类型</li>
        /// <li>PERSONAL-IDCARD : 签署人证件号</li>
        /// <li>TEXT : 单行文本</li>
        /// <li>MULTI_LINE_TEXT : 多行文本</li>
        /// <li>CHECK_BOX : 勾选框</li>
        /// <li>SELECTOR : 选择器</li>
        /// <li>DIGIT : 数字</li>
        /// <li>DATE : 日期</li>
        /// <li>FILL_IMAGE : 图片</li>
        /// <li>ATTACHMENT : 附件</li>
        /// <li>EMAIL : 邮箱</li>
        /// <li>LOCATION : 地址</li>
        /// <li>EDUCATION : 学历</li>
        /// <li>GENDER : 性别</li>
        /// <li>DISTRICT : 省市区</li></ul>
        /// </summary>
        [JsonProperty("HideComponentTypes")]
        public string[] HideComponentTypes{ get; set; }

        /// <summary>
        /// 在发起流程的可嵌入页面要显示的控件列表，和 HideComponentTypes 参数 只能二选一使用（注: 
        /// <font color='red'>空数组代表未指定</font>），具体的控件类型如下
        /// <ul><li>SIGN_SIGNATURE : 个人签名/印章</li>
        /// <li>SIGN_SEAL : 企业印章</li>
        /// <li>SIGN_PAGING_SEAL : 骑缝章</li>
        /// <li>SIGN_LEGAL_PERSON_SEAL : 法定代表人章</li>
        /// <li>SIGN_APPROVE : 签批</li>
        /// <li>SIGN_OPINION : 签署意见</li>
        /// <li>SIGN_PAGING_SIGNATURE : 手写签名骑缝控件</li>
        /// <li>BUSI-FULL-NAME  : 企业全称</li>
        /// <li>BUSI-CREDIT-CODE : 统一社会信用代码</li>
        /// <li>BUSI-LEGAL-NAME : 法人/经营者姓名</li>
        /// <li>PERSONAL-NAME : 签署人姓名</li>
        /// <li>PERSONAL-MOBILE : 签署人手机号</li>
        /// <li>PERSONAL-IDCARD-TYPE : 签署人证件类型</li>
        /// <li>PERSONAL-IDCARD : 签署人证件号</li>
        /// <li>TEXT : 单行文本</li>
        /// <li>MULTI_LINE_TEXT : 多行文本</li>
        /// <li>CHECK_BOX : 勾选框</li>
        /// <li>SELECTOR : 选择器</li>
        /// <li>DIGIT : 数字</li>
        /// <li>DATE : 日期</li>
        /// <li>FILL_IMAGE : 图片</li>
        /// <li>ATTACHMENT : 附件</li>
        /// <li>EMAIL : 邮箱</li>
        /// <li>LOCATION : 地址</li>
        /// <li>EDUCATION : 学历</li>
        /// <li>GENDER : 性别</li>
        /// <li>DISTRICT : 省市区</li></ul>
        /// </summary>
        [JsonProperty("ShowComponentTypes")]
        public string[] ShowComponentTypes{ get; set; }

        /// <summary>
        /// 发起流程的可嵌入页面结果页配置
        /// </summary>
        [JsonProperty("ResultPageConfig")]
        public CreateResultPageConfig[] ResultPageConfig{ get; set; }

        /// <summary>
        /// 签署控件的配置信息，用在嵌入式发起的页面配置，包括 
        ///  - 签署控件 是否默认展示日期.
        /// </summary>
        [JsonProperty("SignComponentConfig")]
        public SignComponentConfig SignComponentConfig{ get; set; }

        /// <summary>
        /// 是否禁止编辑（展示）水印控件属性
        /// <ul><li>（默认） false -否</li> <li> true - 禁止编辑</li></ul>
        /// </summary>
        [JsonProperty("ForbidEditWatermark")]
        public bool? ForbidEditWatermark{ get; set; }

        /// <summary>
        /// 隐藏操作指引: 具体的控件类型如下
        /// 
        /// <ul><li>1 : 操作指引入口</li>
        /// <li>2 : 操作文档</li>
        /// <li>3 : 操作视频</li>
        /// </ul>
        /// 注：仅对新版页面生效
        /// </summary>
        [JsonProperty("HideOperationInstructions")]
        [System.Obsolete]
        public ulong?[] HideOperationInstructions{ get; set; }

        /// <summary>
        /// 隐藏操作步骤: 具体的控件类型如下
        /// 
        /// <ul><li>1 : 选择文件及签署方</li>
        /// <li>2 : 补充文件内容</li>
        /// <li>4 : 发起前合同信息与设置确认</li>
        /// </ul>
        /// 注：仅对新版页面生效
        /// </summary>
        [JsonProperty("HideOperationSteps")]
        public ulong?[] HideOperationSteps{ get; set; }

        /// <summary>
        /// 本企业简称，注：仅对新版页面生效
        /// </summary>
        [JsonProperty("SelfName")]
        public string SelfName{ get; set; }

        /// <summary>
        /// 发起后签署码隐藏，默认false，注：仅对新版页面生效
        /// </summary>
        [JsonProperty("HideSignCodeAfterStart")]
        public bool? HideSignCodeAfterStart{ get; set; }

        /// <summary>
        /// 发起成功后是否预览合同 <ul><li>（默认） false -否</li> <li> true - 展示预览按钮</li></ul>	
        /// </summary>
        [JsonProperty("PreviewAfterStart")]
        public bool? PreviewAfterStart{ get; set; }

        /// <summary>
        /// 发起成功之后是否签署合同，仅当前经办人作为签署人时生效 <ul><li>（默认） false -否</li> <li> true - 展示签署按钮</li></ul>	
        /// </summary>
        [JsonProperty("SignAfterStart")]
        public bool? SignAfterStart{ get; set; }

        /// <summary>
        /// 发起过程中是否保存草稿
        /// </summary>
        [JsonProperty("NeedFlowDraft")]
        public bool? NeedFlowDraft{ get; set; }


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
            this.SetParamSimple(map, prefix + "ForbidAddApprover", this.ForbidAddApprover);
            this.SetParamSimple(map, prefix + "ForbidEditApprover", this.ForbidEditApprover);
            this.SetParamSimple(map, prefix + "ForbidEditFlowProperties", this.ForbidEditFlowProperties);
            this.SetParamArraySimple(map, prefix + "HideComponentTypes.", this.HideComponentTypes);
            this.SetParamArraySimple(map, prefix + "ShowComponentTypes.", this.ShowComponentTypes);
            this.SetParamArrayObj(map, prefix + "ResultPageConfig.", this.ResultPageConfig);
            this.SetParamObj(map, prefix + "SignComponentConfig.", this.SignComponentConfig);
            this.SetParamSimple(map, prefix + "ForbidEditWatermark", this.ForbidEditWatermark);
            this.SetParamArraySimple(map, prefix + "HideOperationInstructions.", this.HideOperationInstructions);
            this.SetParamArraySimple(map, prefix + "HideOperationSteps.", this.HideOperationSteps);
            this.SetParamSimple(map, prefix + "SelfName", this.SelfName);
            this.SetParamSimple(map, prefix + "HideSignCodeAfterStart", this.HideSignCodeAfterStart);
            this.SetParamSimple(map, prefix + "PreviewAfterStart", this.PreviewAfterStart);
            this.SetParamSimple(map, prefix + "SignAfterStart", this.SignAfterStart);
            this.SetParamSimple(map, prefix + "NeedFlowDraft", this.NeedFlowDraft);
        }
    }
}

