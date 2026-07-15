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

    public class AdminChangeInvitationInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>要变更的企业Id。 使用接口进行变更，所支持的企业有两种。</p><p>注意：<br>此参数和 ChangeAdminOrganizationOpenId二选一，如果都传递了，但是不一致会进行报错拦截。</p>
        /// </summary>
        [JsonProperty("ChangeAdminOrganizationId")]
        public string ChangeAdminOrganizationId{ get; set; }

        /// <summary>
        /// <p>要变更的企业Id。 使用接口进行变更，所支持的企业有两种。<br>注意： 此参数和 ChangeAdminOrganizationId二选一，如果都传递了，不一致会进行报错拦截。</p>
        /// </summary>
        [JsonProperty("ChangeAdminOrganizationOpenId")]
        public string ChangeAdminOrganizationOpenId{ get; set; }

        /// <summary>
        /// <p>组织机构要变更的超管OpenId。</p>
        /// </summary>
        [JsonProperty("NewAdminOpenId")]
        public string NewAdminOpenId{ get; set; }

        /// <summary>
        /// <p>组织机构要变更的超管姓名。</p>
        /// </summary>
        [JsonProperty("NewAdminName")]
        public string NewAdminName{ get; set; }

        /// <summary>
        /// <p>组织机构要变更的超管手机号。 跟超管变更的操作人保持一致。</p>
        /// </summary>
        [JsonProperty("NewAdminMobile")]
        public string NewAdminMobile{ get; set; }

        /// <summary>
        /// <p>组织机构要变更的超管证件类型支持以下类型</p><ul><li>ID_CARD : 中国大陆居民身份证 (默认值)</li><li>HONGKONG_AND_MACAO : 中国港澳居民来往内地通行证</li><li>HONGKONG_MACAO_AND_TAIWAN : 中国港澳台居民居住证(格式同中国大陆居民身份证)</li></ul><p>跟超管变更的操作人保持一致。</p><p>枚举值：</p><ul><li>ID_CARD： 中国大陆居民身份证 (默认值)</li><li>HONGKONG_AND_MACAO： 中国港澳居民来往内地通行证</li><li>HONGKONG_MACAO_AND_TAIWAN： 中国港澳台居民居住证(格式同中国大陆居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("NewAdminIdCardType")]
        public string NewAdminIdCardType{ get; set; }

        /// <summary>
        /// <p>组织机构新超管证件号。 跟超管变更的操作人保持一致。</p>
        /// </summary>
        [JsonProperty("NewAdminIdCardNumber")]
        public string NewAdminIdCardNumber{ get; set; }

        /// <summary>
        /// <p>授权书(PNG或JPG或PDF) base64格式, 大小不超过8M 。</p><p> p.s. 如果上传授权书 ，需遵循以下条件 1. 超管的信息（超管姓名，超管手机号）必须为必填参数。</p>
        /// </summary>
        [JsonProperty("AuthFiles")]
        public string[] AuthFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChangeAdminOrganizationId", this.ChangeAdminOrganizationId);
            this.SetParamSimple(map, prefix + "ChangeAdminOrganizationOpenId", this.ChangeAdminOrganizationOpenId);
            this.SetParamSimple(map, prefix + "NewAdminOpenId", this.NewAdminOpenId);
            this.SetParamSimple(map, prefix + "NewAdminName", this.NewAdminName);
            this.SetParamSimple(map, prefix + "NewAdminMobile", this.NewAdminMobile);
            this.SetParamSimple(map, prefix + "NewAdminIdCardType", this.NewAdminIdCardType);
            this.SetParamSimple(map, prefix + "NewAdminIdCardNumber", this.NewAdminIdCardNumber);
            this.SetParamArraySimple(map, prefix + "AuthFiles.", this.AuthFiles);
        }
    }
}

