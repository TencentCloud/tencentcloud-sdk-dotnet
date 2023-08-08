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
        /// 身份证件号码
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 印章名称
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 调用方用户信息，userId 必填。支持填入集团子公司经办人 userId代发合同。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 身份证件类型:
        /// ID_CARD 身份证
        /// PASSPORT 护照
        /// HONGKONG_AND_MACAO 中国香港
        /// FOREIGN_ID_CARD 境外身份
        /// HONGKONG_MACAO_AND_TAIWAN 中国台湾
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
        /// 是否处理印章
        /// 默认不做印章处理。
        /// 取值：false：不做任何处理；
        /// true：做透明化处理和颜色增强。
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
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


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
        }
    }
}

