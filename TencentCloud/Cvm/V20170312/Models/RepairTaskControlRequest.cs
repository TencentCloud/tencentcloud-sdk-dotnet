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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepairTaskControlRequest : AbstractModel
    {
        
        /// <summary>
        /// 待授权任务实例对应的产品类型，支持取值：
        /// 
        /// - `CVM`：云服务器
        /// - `CDH`：专用宿主机
        /// - `CPM2.0`：裸金属云服务器
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 指定待操作的实例ID列表，仅允许对列表中的实例ID相关的维修任务发起授权，可通过 [DescribeTaskInfo](https://cloud.tencent.com/document/api/213/87933) 接口返回值中的`InstanceId`获取。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 指定待操作的维修任务ID，可通过 [DescribeTaskInfo](https://cloud.tencent.com/document/api/213/87933) 接口返回值中的`TaskId`获取。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 操作类型，当前只支持传入`AuthorizeRepair`。
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 预约授权时间，形如`2023-01-01 12:00:00`。预约时间需晚于当前时间至少5分钟，且在48小时之内。
        /// </summary>
        [JsonProperty("OrderAuthTime")]
        public string OrderAuthTime{ get; set; }

        /// <summary>
        /// 附加的授权处理策略，不传或为空时，按默认授权方式进行处理。对于支持弃盘迁移授权的维修任务，当且仅当传入`LossyLocal`时，代表本次授权可允许发起弃盘迁移。
        /// 
        /// 注意：
        /// 1. 指定`TaskSubMethod`为`LossyLocal`调用接口发起**弃盘迁移授权**时，本地盘实例的**所有本地盘数据都会清空**，相当于**重新部署本地盘实例**。
        /// 2. 对于非本地盘实例，或不支持弃盘迁移选项的任务，指定`TaskSubMethod`为`LossyLocal`时接口不会报错，不过后端会自动忽略该参数。
        /// 3. 特别的：如果本地盘实例系统盘是CBS云盘，并且`/etc/fstab`里之前配置了本地盘的自动挂载项，建议可根据业务侧的实际需求，评估是否在对应挂载项追加上`nofail`参数（代表对应挂载点挂载失败不阻塞开机流程）或注释对应的挂载路径。否则授权弃盘迁移后，对应本地盘数据已清空，自动挂载失败会导致实例开机流程失败进入救援模式。具体可参考 [Linux 实例：/etc/fstab 配置错误导致无法登录](https://cloud.tencent.com/document/product/213/72039)。
        /// </summary>
        [JsonProperty("TaskSubMethod")]
        public string TaskSubMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "OrderAuthTime", this.OrderAuthTime);
            this.SetParamSimple(map, prefix + "TaskSubMethod", this.TaskSubMethod);
        }
    }
}

