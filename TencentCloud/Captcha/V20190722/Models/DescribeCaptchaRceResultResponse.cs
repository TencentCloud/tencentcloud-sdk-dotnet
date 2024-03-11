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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaRceResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 1 OK 验证通过
        /// 7 captcha no match 传入的Randstr不合法，请检查Randstr是否与前端返回的Randstr一致
        /// 8 ticket expired 传入的Ticket已过期（Ticket有效期5分钟），请重新生成Ticket、Randstr进行校验
        /// 9 ticket reused 传入的Ticket被重复使用，请重新生成Ticket、Randstr进行校验
        /// 15 decrypt fail 传入的Ticket不合法，请检查Ticket是否与前端返回的Ticket一致
        /// 16 appid-ticket mismatch 传入的CaptchaAppId错误，请检查CaptchaAppId是否与前端传入的CaptchaAppId一致，并且保障CaptchaAppId是从验证码控制台【验证管理】->【基础配置】中获取
        /// 21 diff 票据校验异常，可能的原因是（1）若Ticket包含terror前缀，一般是由于用户网络较差，导致前端自动容灾，而生成了容灾票据，业务侧可根据需要进行跳过或二次处理。（2）若Ticket不包含terror前缀，则是由于验证码风控系统发现请求有安全风险，业务侧可根据需要进行拦截。
        /// 100 appid-secretkey-ticket mismatch 参数校验错误，（1）请检查CaptchaAppId与AppSecretKey是否正确，CaptchaAppId、AppSecretKey需要在验证码控制台【验证管理】>【基础配置】中获取（2）请检查传入的Ticket是否由传入的CaptchaAppId生成
        /// </summary>
        [JsonProperty("CaptchaCode")]
        public long? CaptchaCode{ get; set; }

        /// <summary>
        /// 状态描述及验证错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaptchaMsg")]
        public string CaptchaMsg{ get; set; }

        /// <summary>
        /// 无感验证模式下，该参数返回验证结果：
        /// EvilLevel=0 请求无恶意
        /// EvilLevel=100 请求有恶意
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilLevel")]
        public long? EvilLevel{ get; set; }

        /// <summary>
        /// 前端获取验证码时间，时间戳格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GetCaptchaTime")]
        public long? GetCaptchaTime{ get; set; }

        /// <summary>
        /// 拦截类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilBitmap")]
        public long? EvilBitmap{ get; set; }

        /// <summary>
        /// 提交验证码时间
        /// </summary>
        [JsonProperty("SubmitCaptchaTime")]
        public long? SubmitCaptchaTime{ get; set; }

        /// <summary>
        /// rce检测结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RceResult")]
        public RceResult RceResult{ get; set; }

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
            this.SetParamSimple(map, prefix + "CaptchaCode", this.CaptchaCode);
            this.SetParamSimple(map, prefix + "CaptchaMsg", this.CaptchaMsg);
            this.SetParamSimple(map, prefix + "EvilLevel", this.EvilLevel);
            this.SetParamSimple(map, prefix + "GetCaptchaTime", this.GetCaptchaTime);
            this.SetParamSimple(map, prefix + "EvilBitmap", this.EvilBitmap);
            this.SetParamSimple(map, prefix + "SubmitCaptchaTime", this.SubmitCaptchaTime);
            this.SetParamObj(map, prefix + "RceResult.", this.RceResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

