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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 唯一用户身份标识，由业务方自定义，平台不予理解。（可根据业务需要决定使用用户的唯一身份标识或是使用时间戳随机生成；在用户重连时应保持UserId不变）
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户IP，用户客户端的公网IP，用于就近调度
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 客户端session信息，从SDK请求中获得。特殊的，当 RunMode 参数为 RunWithoutClient 时，该字段可以为空
        /// </summary>
        [JsonProperty("ClientSession")]
        public string ClientSession{ get; set; }

        /// <summary>
        /// 云端运行模式。
        /// RunWithoutClient：允许无客户端连接的情况下仍保持云端 App 运行
        /// 默认值（空）：要求必须有客户端连接才会保持云端 App 运行。
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// 应用启动参数。
        /// 如果请求的是多应用共享项目，此参数生效；
        /// 如果请求的是关闭预启动的单应用独享项目，此参数生效；
        /// 如果请求的是开启预启动的单应用独享项目，此参数失效。
        /// </summary>
        [JsonProperty("ApplicationParameters")]
        public string ApplicationParameters{ get; set; }

        /// <summary>
        /// 【多人互动】房主用户ID，在多人互动模式下为必填字段。
        /// 如果该用户是房主，HostUserId需要和UserId保持一致；
        /// 如果该用户非房主，HostUserId需要填写房主的HostUserId。
        /// </summary>
        [JsonProperty("HostUserId")]
        public string HostUserId{ get; set; }

        /// <summary>
        /// 【多人互动】角色。
        /// Player：玩家（可通过键鼠等操作应用）
        /// Viewer：观察者（只能观看，无法操作）
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "ClientSession", this.ClientSession);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ApplicationParameters", this.ApplicationParameters);
            this.SetParamSimple(map, prefix + "HostUserId", this.HostUserId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
        }
    }
}

