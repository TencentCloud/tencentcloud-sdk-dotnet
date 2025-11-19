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

    public class AdminChangeInvitationInfo : AbstractModel
    {
        
        /// <summary>
        /// 要变更的企业Id。
        /// 使用接口进行变更，所支持的企业有两种。
        /// 1. 集团主企业替子企业进行超管变更。
        ///     子企业的企业 Id 可在更多-组织管理-集团组织管理处获取。如图位置![image](https://qcloudimg.tencent-cloud.cn/raw/3d4469c13ca9e66a847560fc4309c58b.png)
        /// 2. 使用接口[创建企业认证链接](https://qian.tencent.com/developers/companyApis/organizations/CreateOrganizationAuthUrl) 创建的企业，企业 Id 可以从回调[企业引导企业实名认证后回调](https://qian.tencent.com/developers/company/callback_types_staffs#%E5%8D%81%E4%B8%80-%E4%BC%81%E4%B8%9A%E5%BC%95%E5%AF%BC%E4%BC%81%E4%B8%9A%E5%AE%9E%E5%90%8D%E8%AE%A4%E8%AF%81%E5%90%8E%E5%9B%9E%E8%B0%83)得到。
        /// </summary>
        [JsonProperty("ChangeAdminOrganizationId")]
        public string ChangeAdminOrganizationId{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管姓名。 
        /// 跟超管变更的操作人保持一致。
        /// </summary>
        [JsonProperty("NewAdminName")]
        public string NewAdminName{ get; set; }

        /// <summary>
        /// 授权书(PNG或JPG或PDF) base64格式, 大小不超过8M 。
        /// p.s. 如果上传授权书 ，需遵循以下条件
        /// 1. 超管的信息（超管姓名，超管手机号）必须为必填参数。
        /// </summary>
        [JsonProperty("AuthFiles")]
        public string[] AuthFiles{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管手机号。
        /// 跟超管变更的操作人保持一致。
        /// 超管变更的手机号和超管变更的证件号，必须要传递一个。
        /// </summary>
        [JsonProperty("NewAdminMobile")]
        public string NewAdminMobile{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管证件类型支持以下类型
        /// - ID_CARD : 中国大陆居民身份证 (默认值)
        /// - HONGKONG_AND_MACAO : 中国港澳居民来往内地通行证
        /// - HONGKONG_MACAO_AND_TAIWAN : 中国港澳台居民居住证(格式同中国大陆居民身份证)
        /// 
        /// 跟超管变更的操作人保持一致。
        /// </summary>
        [JsonProperty("NewAdminIdCardType")]
        public string NewAdminIdCardType{ get; set; }

        /// <summary>
        /// 组织机构新超管证件号。
        /// 
        /// 跟超管变更的操作人保持一致。
        /// 
        /// 超管变更的手机号和超管变更的证件号，必须要传递一个。
        /// </summary>
        [JsonProperty("NewAdminIdCardNumber")]
        public string NewAdminIdCardNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChangeAdminOrganizationId", this.ChangeAdminOrganizationId);
            this.SetParamSimple(map, prefix + "NewAdminName", this.NewAdminName);
            this.SetParamArraySimple(map, prefix + "AuthFiles.", this.AuthFiles);
            this.SetParamSimple(map, prefix + "NewAdminMobile", this.NewAdminMobile);
            this.SetParamSimple(map, prefix + "NewAdminIdCardType", this.NewAdminIdCardType);
            this.SetParamSimple(map, prefix + "NewAdminIdCardNumber", this.NewAdminIdCardNumber);
        }
    }
}

