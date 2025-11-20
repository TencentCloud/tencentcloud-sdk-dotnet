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

    public class CreateBatchAdminChangeInvitationsUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管姓名。 在超管变更流程中，必须是超管本人进行操作，需要更当前操作人的姓名保持一致。
        /// </summary>
        [JsonProperty("NewAdminName")]
        public string NewAdminName{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管手机号。 
        /// 在超管变更流程中，必须是超管本人进行操作，需要更当前操作人的手机号保持一致。
        /// 
        /// 超管手机号 和超管证件号 二选一 必填。
        /// 
        /// 注意：
        /// 1. 如果新超管的个人身份在电子签进行了手机号的变更，之前提交的超管变更任务将无法获取。
        /// </summary>
        [JsonProperty("NewAdminMobile")]
        public string NewAdminMobile{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管证件类型支持以下类型
        /// - ID_CARD : 中国大陆居民身份证 (默认值)
        /// -  HONGKONG_AND_MACAO : 中国港澳居民来往内地通行证
        /// - HONGKONG_MACAO_AND_TAIWAN : 中国港澳台居民居住证(格式同中国大陆居民身份证)
        /// 需要更当前操作人的证件类型保持一致。
        /// </summary>
        [JsonProperty("NewAdminIdCardType")]
        public string NewAdminIdCardType{ get; set; }

        /// <summary>
        /// 组织机构要变更的超管证件号。 
        /// 在超管变更流程中，必须是超管本人进行操作，需要更当前操作人的证件号保持一致。
        /// 
        /// 超管手机号和超管证件号 二选一必填。
        /// </summary>
        [JsonProperty("NewAdminIdCardNumber")]
        public string NewAdminIdCardNumber{ get; set; }

        /// <summary>
        /// 通知方式。
        ///  NONE（默认）
        ///  SMS  - 如果使用这个方式，则会给即将变更的超管发信息。
        /// 注意：
        /// 发送信息的手机号，是用户传递的手机号。
        /// 如果用户同时传递了证件号，手机号会被用户在电子签注册的手机号进行覆盖。
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 要跳转的链接类型
        /// <ul>
        /// <li> **HTTP**：跳转电子签小程序的http_url，短信通知或者H5跳转适合此类型 ，此时返回长链 （默认类型）。</li><li>**HTTP_SHORT_URL**：跳转电子签小程序的http_url，短信通知或者H5跳转适合此类型，此时返回短链。</li><li>**APP**： 第三方APP或小程序跳转电子签小程序的path，APP或者小程序跳转适合此类型。</li>
        /// <li>**QR_CODE**： 跳转电子签小程序的http_url的二维码形式，可以在页面展示适合此类型。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "NewAdminName", this.NewAdminName);
            this.SetParamSimple(map, prefix + "NewAdminMobile", this.NewAdminMobile);
            this.SetParamSimple(map, prefix + "NewAdminIdCardType", this.NewAdminIdCardType);
            this.SetParamSimple(map, prefix + "NewAdminIdCardNumber", this.NewAdminIdCardNumber);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

