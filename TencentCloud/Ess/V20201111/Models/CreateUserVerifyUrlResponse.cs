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

    public class CreateUserVerifyUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 腾讯电子签小程序的实名认证链接。
        /// 如果没有传递，默认值是 HTTP。 链接的有效期均是 7 天。
        /// 
        /// - 如果EndPoint是APP，
        /// 得到的链接类似于pages/guide/index?to=MP_PERSONAL_VERIFY&shortKey=yDCZHUyOcExAlcOvNod0, 用法可以参考描述中的"跳转到小程序的实现"
        /// 
        /// - 如果EndPoint是HTTP，
        /// 得到的链接类似于https://res.ess.tencent.cn/cdn/h5-activity/jump-mp.html?to=TAG_VERIFY&shortKey=yDCZHUyOcChrfpaswT0d，点击后会跳转到腾讯电子签小程序进行签署
        /// 
        /// - 如果EndPoint是HTTP_SHORT_URL，
        /// 得到的链接类似于https://essurl.cn/2n**42Nd，点击后会跳转到腾讯电子签小程序进行签署
        /// 
        /// 
        /// 注： 生成的链路后面不能再增加参数
        /// 示例值：https://essurl.cn/2n**42Nd
        /// </summary>
        [JsonProperty("UserVerifyUrl")]
        public string UserVerifyUrl{ get; set; }

        /// <summary>
        /// 链接过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 小程序appid，用于半屏拉起电子签小程序， 仅在 Endpoint 设置为 APP 的时候返回
        /// </summary>
        [JsonProperty("MiniAppId")]
        public string MiniAppId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserVerifyUrl", this.UserVerifyUrl);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "MiniAppId", this.MiniAppId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

