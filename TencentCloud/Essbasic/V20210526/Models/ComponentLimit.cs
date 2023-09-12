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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComponentLimit : AbstractModel
    {
        
        /// <summary>
        /// 控件类型，支持以下类型
        /// <ul><li>SIGN_SEAL : 印章控件</li>
        /// <li>SIGN_PAGING_SEAL : 骑缝章控件</li>
        /// <li>SIGN_LEGAL_PERSON_SEAL : 企业法定代表人控件</li>
        /// <li>SIGN_SIGNATURE : 用户签名控件</li></ul>
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// 签署控件类型的值(可选)，用与限制签署时印章或者签名的选择范围
        /// 
        /// 1.当ComponentType 是 SIGN_SEAL 或者 SIGN_PAGING_SEAL 时可传入企业印章Id（支持多个）
        /// 
        /// 2.当ComponentType 是 SIGN_SIGNATURE 时可传入以下类型（支持多个）
        /// 
        /// <ul><li>HANDWRITE : 手写签名</li>
        /// <li>OCR_ESIGN : OCR印章（智慧手写签名）</li>
        /// <li>ESIGN : 个人印章</li>
        /// <li>SYSTEM_ESIGN : 系统印章</li></ul>
        /// 
        /// 3.当ComponentType 是 SIGN_LEGAL_PERSON_SEAL 时无需传递此参数。
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string[] ComponentValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamArraySimple(map, prefix + "ComponentValue.", this.ComponentValue);
        }
    }
}

