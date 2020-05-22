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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MessageCommonGjh : AbstractModel
    {
        
        /// <summary>
        /// 密码（由腾讯提供）
        /// </summary>
        [JsonProperty("StrPassword")]
        public string StrPassword{ get; set; }

        /// <summary>
        /// 账号（由腾讯提供）
        /// </summary>
        [JsonProperty("UiAppID")]
        public long? UiAppID{ get; set; }

        /// <summary>
        /// 业务场景ID: 1：媒体类；2：流媒体类；3：即时通讯类；4：社交日志；5：评论类；6：资料类；7：文件类；8：互动类；9：论坛类
        /// </summary>
        [JsonProperty("UiAppSceneID")]
        public long? UiAppSceneID{ get; set; }

        /// <summary>
        /// 请求序列号，会原样回到给业务侧请求序列号，会原样回到给业务侧，用于上游异步处理
        /// </summary>
        [JsonProperty("UiSeq")]
        public long? UiSeq{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrPassword", this.StrPassword);
            this.SetParamSimple(map, prefix + "UiAppID", this.UiAppID);
            this.SetParamSimple(map, prefix + "UiAppSceneID", this.UiAppSceneID);
            this.SetParamSimple(map, prefix + "UiSeq", this.UiSeq);
        }
    }
}

