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

    public class CreateEmbedWebUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// <br/>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// WEB嵌入资源类型，支持以下类型
        /// <ul><li>CREATE_SEAL: 生成创建印章的嵌入页面</li>
        /// <li>CREATE_TEMPLATE：生成创建模板的嵌入页面</li>
        /// <li>MODIFY_TEMPLATE：生成编辑模板的嵌入页面</li>
        /// <li>CREATE_CONTRACT_DRAFT_COOPEDIT：生成创建起草合同的嵌入页面</li>
        /// <li>PREVIEW_TEMPLATE：生成预览模板的嵌入页面</li>
        /// <li>PREVIEW_SEAL_LIST：生成预览印章列表的嵌入页面</li>
        /// <li>PREVIEW_SEAL_DETAIL：生成预览印章详情的嵌入页面</li>
        /// <li>EXTEND_SERVICE：生成高级签署能力的嵌入页面</li>
        /// <li>PREVIEW_FLOW：生成预览合同的嵌入页面（支持移动端）</li>
        /// <li>PREVIEW_FLOW_DETAIL：生成查看合同详情的嵌入页面（仅支持PC端）</li></ul>
        /// 
        /// 注意：
        /// 不同的嵌入类型，操作人需要的权限项不同（权限配置可参考[权限配置](https://qian.tencent.com/document/61355)）。
        /// <table  border="1">
        /// <thead>
        /// <tr><th>EmbedType</th><th>权限</th></tr>
        /// </thead>     
        /// <tbody> 
        /// <tr><th>CREATE_SEAL</th><th>印章管理-添加印章</th></tr>
        /// <tr><th>CREATE_TEMPLATE</th><th>模板管理-创建模板</th></tr>
        /// <tr><th>MODIFY_TEMPLATE</th><th>模板管理-编辑模板</th></tr>
        /// <tr><th>CREATE_CONTRACT_DRAFT_COOPEDIT</th><th>合同管理-起草合同</th></tr>
        /// <tr><th>PREVIEW_TEMPLATE</th><th>拥有下面三种权限的一种就行</br>
        /// 模板管理-查询模板（本企业全部模板）</br>
        /// 模板管理-查询模板（本部门全部模板）</br>
        /// 模板管理-查询模板（本人创建模板）</th></tr>
        /// <tr><th>PREVIEW_SEAL_LIST</th><th>印章管理</th></tr>
        /// <tr><th>PREVIEW_SEAL_DETAIL</th><th>印章管理</th></tr>
        /// <tr><th>EXTEND_SERVICE</th><th>无要求</th></tr>
        /// <tr><th>PREVIEW_FLOW</th><th>是否是当前合同的参与方，或者发起方企业的法人、超管、合同管理员</th></tr>
        /// <tr><th>PREVIEW_FLOW_DETAIL</th><th>是否是当前合同的参与方，或者发起方企业的法人、超管、合同管理员</th></tr>
        /// </tbody> 
        /// </table>
        /// </summary>
        [JsonProperty("EmbedType")]
        public string EmbedType{ get; set; }

        /// <summary>
        /// WEB嵌入的业务资源ID
        /// 
        /// 当EmbedType取值
        /// <ul>
        /// <li>为PREVIEW_SEAL_DETAIL，必填，取值为印章id。</li>
        /// <li>为CREATE_TEMPLATE，非必填，取值为资源id。*资源Id获取可使用接口[上传文件](https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles)*</li>
        /// <li>为MODIFY_TEMPLATE，PREVIEW_TEMPLATE，必填，取值为模板id。</li>
        /// <li>为CREATE_CONTRACT_DRAFT_COOPEDIT，非必填，取值为资源 id。*资源Id获取可使用接口[上传文件](https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles)*</li>
        /// <li>为PREVIEW_FLOW，PREVIEW_FLOW_DETAIL，必填，取值为合同id。</li>
        /// </ul>
        /// 
        /// 注意：
        ///  1. CREATE_TEMPLATE中的BusinessId仅支持PDF文件类型， 如果您的文件不是PDF， 请使用接口[创建文件转换任务
        /// ](https://qian.tencent.com/developers/companyApis/templatesAndFiles/CreateConvertTaskApi) 和[查询转换任务状态](https://qian.tencent.com/developers/companyApis/templatesAndFiles/GetTaskResultApi) 来进行转换成PDF资源。
        ///  2. CREATE_CONTRACT_DRAFT_COOPEDIT中的BusinessId仅支持DOC 和 DOCX 的文件，并且大小不能超过 10M。
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// <br/>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 抄送方信息
        /// </summary>
        [JsonProperty("Reviewer")]
        public ReviewerInfo Reviewer{ get; set; }

        /// <summary>
        /// 个性化参数，用于控制页面展示内容
        /// </summary>
        [JsonProperty("Option")]
        public EmbedUrlOption Option{ get; set; }

        /// <summary>
        /// <ul> <li>目前仅支持EmbedType=CREATE_TEMPLATE时传入</li> <li>指定后，创建，编辑，删除模板时，回调都会携带该userData</li> <li>支持的格式：json字符串的BASE64编码字符串</li> <li>示例：<ul>                  <li>json字符串：{"ComeFrom":"xxx"}，BASE64编码：eyJDb21lRnJvbSI6Inh4eCJ9</li>                  <li>eyJDb21lRnJvbSI6Inh4eCJ9，为符合要求的userData数据格式</li> </ul> </li> </ul>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "EmbedType", this.EmbedType);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "Reviewer.", this.Reviewer);
            this.SetParamObj(map, prefix + "Option.", this.Option);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
        }
    }
}

