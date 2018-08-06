/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID，可使用[查询项目列表](https://cloud.tencent.com/document/product/378/4400)接口查询项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 实例类型，可取值：1-主实例，2-灾备实例，3-只读实例
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public ulong?[] InstanceTypes{ get; set; }

        /// <summary>
        /// 实例的内网IP地址
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// 实例状态，可取值：0-创建中，1-运行中，4-隔离中，5-已隔离
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// 记录偏移量，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单次请求返回的数量，默认值为20，最大值为2000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// 付费类型，可取值：0-包年包月，1-小时计费
        /// </summary>
        [JsonProperty("PayTypes")]
        public ulong?[] PayTypes{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// 实例任务状态，可能取值：<br>0-没有任务<br>1-升级中<br>2-数据导入中<br>3-开放Slave中<br>4-外网访问开通中<br>5-批量操作执行中<br>6-回档中<br>7-外网访问关闭中<br>8-密码修改中<br>9-实例名修改中<br>10-重启中<br>12-自建迁移中<br>13-删除库表中<br>14-灾备实例创建同步中
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong?[] TaskStatus{ get; set; }

        /// <summary>
        /// 实例数据库引擎版本，可能取值：5.1、5.5、5.6和5.7
        /// </summary>
        [JsonProperty("EngineVersions")]
        public string[] EngineVersions{ get; set; }

        /// <summary>
        /// 私有网络的ID
        /// </summary>
        [JsonProperty("VpcIds")]
        public ulong?[] VpcIds{ get; set; }

        /// <summary>
        /// 可用区的ID
        /// </summary>
        [JsonProperty("ZoneIds")]
        public ulong?[] ZoneIds{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetIds")]
        public ulong?[] SubnetIds{ get; set; }

        /// <summary>
        /// 是否锁定标记
        /// </summary>
        [JsonProperty("CdbErrors")]
        public long?[] CdbErrors{ get; set; }

        /// <summary>
        /// 排序的字段，目前支持："InstanceId", "InstanceName", "CreateTime", "DeadlineTime"
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，目前支持："ASC"或者"DESC"
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// 是否包含安全组信息
        /// </summary>
        [JsonProperty("WithSecurityGroup")]
        public long? WithSecurityGroup{ get; set; }

        /// <summary>
        /// 是否包含独享集群信息
        /// </summary>
        [JsonProperty("WithExCluster")]
        public long? WithExCluster{ get; set; }

        /// <summary>
        /// 独享集群ID
        /// </summary>
        [JsonProperty("ExClusterId")]
        public string ExClusterId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 初始化标记，可取值：0-未初始化，1-初始化
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// 是否包含灾备实例
        /// </summary>
        [JsonProperty("WithDr")]
        public long? WithDr{ get; set; }

        /// <summary>
        /// 是否包含只读实例
        /// </summary>
        [JsonProperty("WithRo")]
        public long? WithRo{ get; set; }

        /// <summary>
        /// 是否包含主实例
        /// </summary>
        [JsonProperty("WithMaster")]
        public long? WithMaster{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArraySimple(map, prefix + "Vips.", this.Vips);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArraySimple(map, prefix + "PayTypes.", this.PayTypes);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "EngineVersions.", this.EngineVersions);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "CdbErrors.", this.CdbErrors);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "WithSecurityGroup", this.WithSecurityGroup);
            this.SetParamSimple(map, prefix + "WithExCluster", this.WithExCluster);
            this.SetParamSimple(map, prefix + "ExClusterId", this.ExClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InitFlag", this.InitFlag);
            this.SetParamSimple(map, prefix + "WithDr", this.WithDr);
            this.SetParamSimple(map, prefix + "WithRo", this.WithRo);
            this.SetParamSimple(map, prefix + "WithMaster", this.WithMaster);
        }
    }
}

