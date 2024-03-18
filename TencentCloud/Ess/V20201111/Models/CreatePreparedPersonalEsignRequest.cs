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

    public class CreatePreparedPersonalEsignRequest : AbstractModel
    {
        
        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给香港居民，“M”字头签发给澳门居民；第2位至第11位为数字。。</li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 印章名称，长度1-50个字。
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证 (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 印章图片的base64
        /// 注：已废弃
        /// 请先通过UploadFiles接口上传文件，获取 FileId
        /// </summary>
        [JsonProperty("SealImage")]
        [System.Obsolete]
        public string SealImage{ get; set; }

        /// <summary>
        /// 是否开启印章图片压缩处理，默认不开启，如需开启请设置为 true。当印章超过 2M 时建议开启，开启后图片的 hash 将发生变化。
        /// </summary>
        [JsonProperty("SealImageCompress")]
        public bool? SealImageCompress{ get; set; }

        /// <summary>
        /// 手机号码；当需要开通自动签时，该参数必传
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 是否开通自动签，该功能需联系运营工作人员开通后使用
        /// </summary>
        [JsonProperty("EnableAutoSign")]
        public bool? EnableAutoSign{ get; set; }

        /// <summary>
        /// 印章颜色（参数ProcessSeal=true时生效）
        /// 默认值：BLACK黑色
        /// 取值: 
        /// BLACK 黑色,
        /// RED 红色,
        /// BLUE 蓝色。
        /// </summary>
        [JsonProperty("SealColor")]
        public string SealColor{ get; set; }

        /// <summary>
        /// 是否处理印章，默认不做印章处理。
        /// 取值如下：
        /// <ul>
        /// <li>false：不做任何处理；</li>
        /// <li>true：做透明化处理和颜色增强。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ProcessSeal")]
        public bool? ProcessSeal{ get; set; }

        /// <summary>
        /// 印章图片文件 id
        /// 取值：
        /// 填写的FileId通过UploadFiles接口上传文件获取。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 设置用户开通自动签时是否绑定个人自动签账号许可。一旦绑定后，将扣减购买的个人自动签账号许可一次（1年有效期），不可解绑释放。不传默认为绑定自动签账号许可。 0-绑定个人自动签账号许可，开通后将扣减购买的个人自动签账号许可一次 1-不绑定，发起合同时将按标准合同套餐进行扣减	
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }

        /// <summary>
        /// 自动签使用的场景值, 可以选择的场景值如下:
        /// <ul><li> **E_PRESCRIPTION_AUTO_SIGN** :  电子处方场景</li><li> **OTHER** :  通用场景</li></ul>
        /// 
        /// 注: `不传默认为处方单场景，即E_PRESCRIPTION_AUTO_SIGN`
        /// </summary>
        [JsonProperty("SceneKey")]
        public string SceneKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "SealImage", this.SealImage);
            this.SetParamSimple(map, prefix + "SealImageCompress", this.SealImageCompress);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "EnableAutoSign", this.EnableAutoSign);
            this.SetParamSimple(map, prefix + "SealColor", this.SealColor);
            this.SetParamSimple(map, prefix + "ProcessSeal", this.ProcessSeal);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "SceneKey", this.SceneKey);
        }
    }
}

