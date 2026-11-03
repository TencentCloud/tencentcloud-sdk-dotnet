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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateLocationRequest : AbstractModel
    {
        
        /// <summary>
        /// 存储位置名，必填
        /// </summary>
        [JsonProperty("LocationName")]
        public string LocationName{ get; set; }

        /// <summary>
        /// 更新location的操作列表，必填。通过 UpdateType 指定操作类型，支持的 UpdateType：modify_location_name（修改名称）、modify_location_comment（修改描述）、modify_location_properties（修改属性）、modify_file_event_subscription（操作COS文件事件订阅开关）
        /// </summary>
        [JsonProperty("Updates")]
        public LocationUpdate[] Updates{ get; set; }

        /// <summary>
        /// 调用时所在workspace唯一id，必填
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// COS 文件事件订阅配置，可选；不设置时不改动现有订阅（仅 COS 类型 Location 生效）。设置时：先按新配置重新订阅（同桶覆盖写，幂等），再修改 Location 元数据。与 Updates 中的 modify_file_event_subscription 配合表达开关操作：Updates 含该类型且本字段有值=开启/编辑订阅；Updates 含该类型且本字段未设置=关闭订阅；Updates 不含该类型时维持默认语义（不设置不动、设置覆盖）
        /// </summary>
        [JsonProperty("FileEventSubscription")]
        public CosEventSubscription FileEventSubscription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocationName", this.LocationName);
            this.SetParamArrayObj(map, prefix + "Updates.", this.Updates);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "FileEventSubscription.", this.FileEventSubscription);
        }
    }
}

