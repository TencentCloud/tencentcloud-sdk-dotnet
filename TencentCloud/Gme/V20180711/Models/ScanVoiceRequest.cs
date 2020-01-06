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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，登录[控制台 - 服务管理](https://console.cloud.tencent.com/gamegme)创建应用得到的AppID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 语音检测场景，参数值目前要求为 default。 预留场景设置： 谩骂、色情、涉政、广告、暴恐、违禁等场景，<a href="#Label_Value">具体取值见上述 Label 说明。</a>
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// 是否为直播流。值为 false 时表示普通语音文件检测；为 true 时表示语音流检测。
        /// </summary>
        [JsonProperty("Live")]
        public bool? Live{ get; set; }

        /// <summary>
        /// 语音检测任务列表，列表最多支持100个检测任务。结构体中包含：
        /// <li>DataId：数据的唯一ID</li>
        /// <li>Url：数据文件的url，为 urlencode 编码，流式则为拉流地址</li>
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// 异步检测结果回调地址，具体见上述<a href="#Callback_Declare">回调相关说明</a>。（说明：该字段为空时，必须通过接口(查询语音检测结果)获取检测结果）。
        /// </summary>
        [JsonProperty("Callback")]
        public string Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "Live", this.Live);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Callback", this.Callback);
        }
    }
}

