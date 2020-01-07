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

namespace TencentCloud.Cbs.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cbs.V20170312.Models;

   public class CbsClient : AbstractClient{

       private const string endpoint = "cbs.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CbsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CbsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（ApplySnapshot）用于回滚快照到原云硬盘。
        /// 
        /// * 仅支持回滚到原云硬盘上。对于数据盘快照，如果您需要复制快照数据到其它云硬盘上，请使用[CreateDisks](/document/product/362/16312)接口创建新的弹性云盘，将快照数据复制到新购云盘上。 
        /// * 用于回滚的快照必须处于NORMAL状态。快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 如果是弹性云盘，则云盘必须处于未挂载状态，云硬盘挂载状态可以通过[DescribeDisks](/document/product/362/16315)接口查询，见Attached字段解释；如果是随实例一起购买的非弹性云盘，则实例必须处于关机状态，实例状态可以通过[DescribeInstancesStatus](/document/product/213/15738)接口查询。
        /// </summary>
        /// <param name="req"><see cref="ApplySnapshotRequest"/></param>
        /// <returns><see cref="ApplySnapshotResponse"/></returns>
        public async Task<ApplySnapshotResponse> ApplySnapshot(ApplySnapshotRequest req)
        {
             JsonResponseModel<ApplySnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplySnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ApplySnapshot接口的同步版本，本接口（ApplySnapshot）用于回滚快照到原云硬盘。
        /// 
        /// * 仅支持回滚到原云硬盘上。对于数据盘快照，如果您需要复制快照数据到其它云硬盘上，请使用[CreateDisks](/document/product/362/16312)接口创建新的弹性云盘，将快照数据复制到新购云盘上。 
        /// * 用于回滚的快照必须处于NORMAL状态。快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 如果是弹性云盘，则云盘必须处于未挂载状态，云硬盘挂载状态可以通过[DescribeDisks](/document/product/362/16315)接口查询，见Attached字段解释；如果是随实例一起购买的非弹性云盘，则实例必须处于关机状态，实例状态可以通过[DescribeInstancesStatus](/document/product/213/15738)接口查询。
        /// </summary>
        /// <param name="req">参考<see cref="ApplySnapshotRequest"/></param>
        /// <returns>参考<see cref="ApplySnapshotResponse"/>实例</returns>
        public ApplySnapshotResponse ApplySnapshotSync(ApplySnapshotRequest req)
        {
             JsonResponseModel<ApplySnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplySnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载云硬盘。
        ///  
        /// * 支持批量操作，将多块云盘挂载到同一云主机。如果多个云盘存在不允许挂载的云盘，则操作不执行，以返回特定的错误码返回。
        /// * 本接口为异步接口，当挂载云盘的请求成功返回时，表示后台已发起挂载云盘的操作，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHING”变为“ATTACHED”，则为挂载成功。
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public async Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AttachDisks接口的同步版本，本接口（AttachDisks）用于挂载云硬盘。
        ///  
        /// * 支持批量操作，将多块云盘挂载到同一云主机。如果多个云盘存在不允许挂载的云盘，则操作不执行，以返回特定的错误码返回。
        /// * 本接口为异步接口，当挂载云盘的请求成功返回时，表示后台已发起挂载云盘的操作，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHING”变为“ATTACHED”，则为挂载成功。
        /// </summary>
        /// <param name="req">参考<see cref="AttachDisksRequest"/></param>
        /// <returns>参考<see cref="AttachDisksResponse"/>实例</returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindAutoSnapshotPolicy）用于绑定云硬盘到指定的定期快照策略。
        /// 
        /// * 每个地域下的定期快照策略配额限制请参考文档[定期快照](/document/product/362/8191)。
        /// * 当已绑定定期快照策略的云硬盘处于未使用状态（即弹性云盘未挂载或非弹性云盘的主机处于关机状态）将不会创建定期快照。
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public async Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindAutoSnapshotPolicy接口的同步版本，本接口（BindAutoSnapshotPolicy）用于绑定云硬盘到指定的定期快照策略。
        /// 
        /// * 每个地域下的定期快照策略配额限制请参考文档[定期快照](/document/product/362/8191)。
        /// * 当已绑定定期快照策略的云硬盘处于未使用状态（即弹性云盘未挂载或非弹性云盘的主机处于关机状态）将不会创建定期快照。
        /// </summary>
        /// <param name="req">参考<see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns>参考<see cref="BindAutoSnapshotPolicyResponse"/>实例</returns>
        public BindAutoSnapshotPolicyResponse BindAutoSnapshotPolicySync(BindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAutoSnapshotPolicy）用于创建定期快照策略。
        /// 
        /// * 每个地域可创建的定期快照策略数量限制请参考文档[定期快照](/document/product/362/8191)。
        /// * 每个地域可创建的快照有数量和容量的限制，具体请见腾讯云控制台快照页面提示，如果快照超配额，定期快照创建会失败。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateAutoSnapshotPolicy接口的同步版本，本接口（CreateAutoSnapshotPolicy）用于创建定期快照策略。
        /// 
        /// * 每个地域可创建的定期快照策略数量限制请参考文档[定期快照](/document/product/362/8191)。
        /// * 每个地域可创建的快照有数量和容量的限制，具体请见腾讯云控制台快照页面提示，如果快照超配额，定期快照创建会失败。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateAutoSnapshotPolicyResponse"/>实例</returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicySync(CreateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDisks）用于创建云硬盘。
        /// 
        /// * 预付费云盘的购买会预先扣除本次云盘购买所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口支持传入数据盘快照来创建云盘，实现将快照数据复制到新购云盘上。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个新建的云盘ID列表，此时云盘的创建并未立即完成。可以通过调用[DescribeDisks](/document/product/362/16315)接口根据DiskId查询对应云盘，如果能查到云盘，且状态为'UNATTACHED'或'ATTACHED'，则表示创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public async Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
             JsonResponseModel<CreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDisks接口的同步版本，本接口（CreateDisks）用于创建云硬盘。
        /// 
        /// * 预付费云盘的购买会预先扣除本次云盘购买所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口支持传入数据盘快照来创建云盘，实现将快照数据复制到新购云盘上。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个新建的云盘ID列表，此时云盘的创建并未立即完成。可以通过调用[DescribeDisks](/document/product/362/16315)接口根据DiskId查询对应云盘，如果能查到云盘，且状态为'UNATTACHED'或'ATTACHED'，则表示创建成功。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDisksRequest"/></param>
        /// <returns>参考<see cref="CreateDisksResponse"/>实例</returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
             JsonResponseModel<CreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSnapshot）用于对指定云盘创建快照。
        /// 
        /// * 只有具有快照能力的云硬盘才能创建快照。云硬盘是否具有快照能力可由[DescribeDisks](/document/product/362/16315)接口查询，见SnapshotAbility字段。
        /// * 可创建快照数量限制见[产品使用限制](https://cloud.tencent.com/doc/product/362/5145)。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public async Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateSnapshot接口的同步版本，本接口（CreateSnapshot）用于对指定云盘创建快照。
        /// 
        /// * 只有具有快照能力的云硬盘才能创建快照。云硬盘是否具有快照能力可由[DescribeDisks](/document/product/362/16315)接口查询，见SnapshotAbility字段。
        /// * 可创建快照数量限制见[产品使用限制](https://cloud.tencent.com/doc/product/362/5145)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSnapshotRequest"/></param>
        /// <returns>参考<see cref="CreateSnapshotResponse"/>实例</returns>
        public CreateSnapshotResponse CreateSnapshotSync(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAutoSnapshotPolicies）用于删除定期快照策略。
        /// 
        /// *  支持批量操作。如果多个定期快照策略存在无法删除的，则操作不执行，以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPoliciesResponse"/></returns>
        public async Task<DeleteAutoSnapshotPoliciesResponse> DeleteAutoSnapshotPolicies(DeleteAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteAutoSnapshotPolicies接口的同步版本，本接口（DeleteAutoSnapshotPolicies）用于删除定期快照策略。
        /// 
        /// *  支持批量操作。如果多个定期快照策略存在无法删除的，则操作不执行，以特定错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAutoSnapshotPoliciesRequest"/></param>
        /// <returns>参考<see cref="DeleteAutoSnapshotPoliciesResponse"/>实例</returns>
        public DeleteAutoSnapshotPoliciesResponse DeleteAutoSnapshotPoliciesSync(DeleteAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 
        /// * 快照必须处于NORMAL状态，快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 支持批量操作。如果多个快照存在无法删除的快照，则操作不执行，以返回特定的错误码返回。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteSnapshots接口的同步版本，本接口（DeleteSnapshots）用于删除快照。
        /// 
        /// * 快照必须处于NORMAL状态，快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 支持批量操作。如果多个快照存在无法删除的快照，则操作不执行，以返回特定的错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSnapshotsRequest"/></param>
        /// <returns>参考<see cref="DeleteSnapshotsResponse"/>实例</returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoSnapshotPolicies）用于查询定期快照策略。
        /// 
        /// * 可以根据定期快照策略ID、名称或者状态等信息来查询定期快照策略的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的定期快照策略表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAutoSnapshotPolicies接口的同步版本，本接口（DescribeAutoSnapshotPolicies）用于查询定期快照策略。
        /// 
        /// * 可以根据定期快照策略ID、名称或者状态等信息来查询定期快照策略的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的定期快照策略表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoSnapshotPoliciesResponse"/>实例</returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDiskAssociatedAutoSnapshotPolicy）用于查询云盘绑定的定期快照策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/></returns>
        public async Task<DescribeDiskAssociatedAutoSnapshotPolicyResponse> DescribeDiskAssociatedAutoSnapshotPolicy(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskAssociatedAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDiskAssociatedAutoSnapshotPolicy接口的同步版本，本接口（DescribeDiskAssociatedAutoSnapshotPolicy）用于查询云盘绑定的定期快照策略。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDiskAssociatedAutoSnapshotPolicyRequest"/></param>
        /// <returns>参考<see cref="DescribeDiskAssociatedAutoSnapshotPolicyResponse"/>实例</returns>
        public DescribeDiskAssociatedAutoSnapshotPolicyResponse DescribeDiskAssociatedAutoSnapshotPolicySync(DescribeDiskAssociatedAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskAssociatedAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskAssociatedAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDiskConfigQuota）用于查询云硬盘配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigQuotaResponse"/></returns>
        public async Task<DescribeDiskConfigQuotaResponse> DescribeDiskConfigQuota(DescribeDiskConfigQuotaRequest req)
        {
             JsonResponseModel<DescribeDiskConfigQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskConfigQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDiskConfigQuota接口的同步版本，本接口（DescribeDiskConfigQuota）用于查询云硬盘配额。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDiskConfigQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeDiskConfigQuotaResponse"/>实例</returns>
        public DescribeDiskConfigQuotaResponse DescribeDiskConfigQuotaSync(DescribeDiskConfigQuotaRequest req)
        {
             JsonResponseModel<DescribeDiskConfigQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskConfigQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDiskOperationLogs）用于查询云盘操作日志列表。
        /// 
        /// 可根据云盘ID过滤。云盘ID形如：disk-a1kmcp13。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeDiskOperationLogsResponse"/></returns>
        public async Task<DescribeDiskOperationLogsResponse> DescribeDiskOperationLogs(DescribeDiskOperationLogsRequest req)
        {
             JsonResponseModel<DescribeDiskOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDiskOperationLogs接口的同步版本，本接口（DescribeDiskOperationLogs）用于查询云盘操作日志列表。
        /// 
        /// 可根据云盘ID过滤。云盘ID形如：disk-a1kmcp13。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDiskOperationLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeDiskOperationLogsResponse"/>实例</returns>
        public DescribeDiskOperationLogsResponse DescribeDiskOperationLogsSync(DescribeDiskOperationLogsRequest req)
        {
             JsonResponseModel<DescribeDiskOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘列表。
        /// 
        /// * 可以根据云硬盘ID、云硬盘类型或者云硬盘状态等信息来查询云硬盘的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的云硬盘列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public async Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDisks接口的同步版本，本接口（DescribeDisks）用于查询云硬盘列表。
        /// 
        /// * 可以根据云硬盘ID、云硬盘类型或者云硬盘状态等信息来查询云硬盘的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的云硬盘列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDisksRequest"/></param>
        /// <returns>参考<see cref="DescribeDisksResponse"/>实例</returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesDiskNum）用于查询实例已挂载云硬盘数量。
        /// 
        /// * 支持批量操作，当传入多个云服务器实例ID，返回结果会分别列出每个云服务器挂载的云硬盘数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public async Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstancesDiskNum接口的同步版本，本接口（DescribeInstancesDiskNum）用于查询实例已挂载云硬盘数量。
        /// 
        /// * 支持批量操作，当传入多个云服务器实例ID，返回结果会分别列出每个云服务器挂载的云硬盘数量。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesDiskNumResponse"/>实例</returns>
        public DescribeInstancesDiskNumResponse DescribeInstancesDiskNumSync(DescribeInstancesDiskNumRequest req)
        {
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotOperationLogs）用于查询快照操作日志列表。
        /// 
        /// 可根据快照ID过滤。快照ID形如：snap-a1kmcp13。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public async Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSnapshotOperationLogs接口的同步版本，本接口（DescribeSnapshotOperationLogs）用于查询快照操作日志列表。
        /// 
        /// 可根据快照ID过滤。快照ID形如：snap-a1kmcp13。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeSnapshotOperationLogsResponse"/>实例</returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotSharePermission）用于查询快照的分享信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeSnapshotSharePermissionResponse"/></returns>
        public async Task<DescribeSnapshotSharePermissionResponse> DescribeSnapshotSharePermission(DescribeSnapshotSharePermissionRequest req)
        {
             JsonResponseModel<DescribeSnapshotSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSnapshotSharePermission接口的同步版本，本接口（DescribeSnapshotSharePermission）用于查询快照的分享信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSnapshotSharePermissionRequest"/></param>
        /// <returns>参考<see cref="DescribeSnapshotSharePermissionResponse"/>实例</returns>
        public DescribeSnapshotSharePermissionResponse DescribeSnapshotSharePermissionSync(DescribeSnapshotSharePermissionRequest req)
        {
             JsonResponseModel<DescribeSnapshotSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// 
        /// * 根据快照ID、创建快照的云硬盘ID、创建快照的云硬盘类型等对结果进行过滤，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// *  如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的快照列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSnapshots接口的同步版本，本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// 
        /// * 根据快照ID、创建快照的云硬盘ID、创建快照的云硬盘类型等对结果进行过滤，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// *  如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的快照列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSnapshotsRequest"/></param>
        /// <returns>参考<see cref="DescribeSnapshotsResponse"/>实例</returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachDisks）用于解挂云硬盘。
        /// 
        /// * 支持批量操作，解挂挂载在同一主机上的多块云盘。如果多块云盘存在不允许解挂载的云盘，则操作不执行，以返回特定的错误码返回。
        /// * 本接口为异步接口，当请求成功返回时，云盘并未立即从主机解挂载，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHED”变为“UNATTACHED”，则为解挂载成功。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public async Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DetachDisks接口的同步版本，本接口（DetachDisks）用于解挂云硬盘。
        /// 
        /// * 支持批量操作，解挂挂载在同一主机上的多块云盘。如果多块云盘存在不允许解挂载的云盘，则操作不执行，以返回特定的错误码返回。
        /// * 本接口为异步接口，当请求成功返回时，云盘并未立即从主机解挂载，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHED”变为“UNATTACHED”，则为解挂载成功。
        /// </summary>
        /// <param name="req">参考<see cref="DetachDisksRequest"/></param>
        /// <returns>参考<see cref="DetachDisksResponse"/>实例</returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateDisks）用于创建云硬盘询价。
        /// 
        /// * 支持查询创建多块云硬盘的价格，此时返回结果为总价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDisksResponse"/></returns>
        public async Task<InquiryPriceCreateDisksResponse> InquiryPriceCreateDisks(InquiryPriceCreateDisksRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceCreateDisks接口的同步版本，本接口（InquiryPriceCreateDisks）用于创建云硬盘询价。
        /// 
        /// * 支持查询创建多块云硬盘的价格，此时返回结果为总价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateDisksRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateDisksResponse"/>实例</returns>
        public InquiryPriceCreateDisksResponse InquiryPriceCreateDisksSync(InquiryPriceCreateDisksRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDisks）用于续费云硬盘询价。
        /// 
        /// * 只支持查询预付费模式的弹性云盘续费价格。
        /// * 支持与挂载实例一起续费的场景，需要在[DiskChargePrepaid](/document/product/362/15669#DiskChargePrepaid)参数中指定CurInstanceDeadline，此时会按对齐到实例续费后的到期时间来续费询价。
        /// * 支持为多块云盘指定不同的续费时长，此时返回的价格为多块云盘续费的总价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDisksResponse"/></returns>
        public async Task<InquiryPriceRenewDisksResponse> InquiryPriceRenewDisks(InquiryPriceRenewDisksRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceRenewDisks接口的同步版本，本接口（InquiryPriceRenewDisks）用于续费云硬盘询价。
        /// 
        /// * 只支持查询预付费模式的弹性云盘续费价格。
        /// * 支持与挂载实例一起续费的场景，需要在[DiskChargePrepaid](/document/product/362/15669#DiskChargePrepaid)参数中指定CurInstanceDeadline，此时会按对齐到实例续费后的到期时间来续费询价。
        /// * 支持为多块云盘指定不同的续费时长，此时返回的价格为多块云盘续费的总价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRenewDisksRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRenewDisksResponse"/>实例</returns>
        public InquiryPriceRenewDisksResponse InquiryPriceRenewDisksSync(InquiryPriceRenewDisksRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceResizeDisk）用于扩容云硬盘询价。
        /// 
        /// * 只支持预付费模式的云硬盘扩容询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeDiskResponse"/></returns>
        public async Task<InquiryPriceResizeDiskResponse> InquiryPriceResizeDisk(InquiryPriceResizeDiskRequest req)
        {
             JsonResponseModel<InquiryPriceResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceResizeDisk接口的同步版本，本接口（InquiryPriceResizeDisk）用于扩容云硬盘询价。
        /// 
        /// * 只支持预付费模式的云硬盘扩容询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResizeDiskRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResizeDiskResponse"/>实例</returns>
        public InquiryPriceResizeDiskResponse InquiryPriceResizeDiskSync(InquiryPriceResizeDiskRequest req)
        {
             JsonResponseModel<InquiryPriceResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAutoSnapshotPolicyAttribute）用于修改定期快照策略属性。
        /// 
        /// * 可通过该接口修改定期快照策略的执行策略、名称、是否激活等属性。
        /// * 修改保留天数时必须保证不与是否永久保留属性冲突，否则整个操作失败，以特定的错误码返回。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoSnapshotPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoSnapshotPolicyAttributeResponse"/></returns>
        public async Task<ModifyAutoSnapshotPolicyAttributeResponse> ModifyAutoSnapshotPolicyAttribute(ModifyAutoSnapshotPolicyAttributeRequest req)
        {
             JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoSnapshotPolicyAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAutoSnapshotPolicyAttribute接口的同步版本，本接口（ModifyAutoSnapshotPolicyAttribute）用于修改定期快照策略属性。
        /// 
        /// * 可通过该接口修改定期快照策略的执行策略、名称、是否激活等属性。
        /// * 修改保留天数时必须保证不与是否永久保留属性冲突，否则整个操作失败，以特定的错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoSnapshotPolicyAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoSnapshotPolicyAttributeResponse"/>实例</returns>
        public ModifyAutoSnapshotPolicyAttributeResponse ModifyAutoSnapshotPolicyAttributeSync(ModifyAutoSnapshotPolicyAttributeRequest req)
        {
             JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoSnapshotPolicyAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoSnapshotPolicyAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 只支持修改弹性云盘的项目ID。随云主机创建的云硬盘项目ID与云主机联动。可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中Portable字段解释。
        /// * “云硬盘名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行云盘管理操作的依据。
        /// * 支持批量操作，如果传入多个云盘ID，则所有云盘修改为同一属性。如果存在不允许操作的云盘，则操作不执行，以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskAttributesRequest"/></param>
        /// <returns><see cref="ModifyDiskAttributesResponse"/></returns>
        public async Task<ModifyDiskAttributesResponse> ModifyDiskAttributes(ModifyDiskAttributesRequest req)
        {
             JsonResponseModel<ModifyDiskAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDiskAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiskAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDiskAttributes接口的同步版本，* 只支持修改弹性云盘的项目ID。随云主机创建的云硬盘项目ID与云主机联动。可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中Portable字段解释。
        /// * “云硬盘名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行云盘管理操作的依据。
        /// * 支持批量操作，如果传入多个云盘ID，则所有云盘修改为同一属性。如果存在不允许操作的云盘，则操作不执行，以特定错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDiskAttributesRequest"/></param>
        /// <returns>参考<see cref="ModifyDiskAttributesResponse"/>实例</returns>
        public ModifyDiskAttributesResponse ModifyDiskAttributesSync(ModifyDiskAttributesRequest req)
        {
             JsonResponseModel<ModifyDiskAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDiskAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiskAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： cbs.tencentcloudapi.com 。
        /// 
        /// 本接口 (ModifyDisksChargeType) 用于切换云盘的计费模式。
        /// 
        /// 只支持从 POSTPAID_BY_HOUR 计费模式切换为PREPAID计费模式。
        /// 非弹性云盘不支持此接口，请通过修改实例计费模式接口将实例连同非弹性云盘一起转换。
        /// 默认接口请求频率限制：10次/秒。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDisksChargeTypeResponse"/></returns>
        public async Task<ModifyDisksChargeTypeResponse> ModifyDisksChargeType(ModifyDisksChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDisksChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDisksChargeType接口的同步版本，接口请求域名： cbs.tencentcloudapi.com 。
        /// 
        /// 本接口 (ModifyDisksChargeType) 用于切换云盘的计费模式。
        /// 
        /// 只支持从 POSTPAID_BY_HOUR 计费模式切换为PREPAID计费模式。
        /// 非弹性云盘不支持此接口，请通过修改实例计费模式接口将实例连同非弹性云盘一起转换。
        /// 默认接口请求频率限制：10次/秒。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDisksChargeTypeRequest"/></param>
        /// <returns>参考<see cref="ModifyDisksChargeTypeResponse"/>实例</returns>
        public ModifyDisksChargeTypeResponse ModifyDisksChargeTypeSync(ModifyDisksChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDisksChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识，支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public async Task<ModifyDisksRenewFlagResponse> ModifyDisksRenewFlag(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDisksRenewFlag接口的同步版本，本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识，支持批量修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyDisksRenewFlagResponse"/>实例</returns>
        public ModifyDisksRenewFlagResponse ModifyDisksRenewFlagSync(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// 
        /// * 当前仅支持修改快照名称及将非永久快照修改为永久快照。
        /// * “快照名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行快照管理操作的依据。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifySnapshotAttribute接口的同步版本，本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// 
        /// * 当前仅支持修改快照名称及将非永久快照修改为永久快照。
        /// * “快照名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行快照管理操作的依据。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySnapshotAttributeResponse"/>实例</returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeSync(ModifySnapshotAttributeRequest req)
        {
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotsSharePermission）用于修改快照分享信息。
        /// 
        /// 分享快照后，被分享账户可以通过该快照创建云硬盘。
        /// * 每个快照最多可分享给50个账户。
        /// * 分享快照无法更改名称，描述，仅可用于创建云硬盘。
        /// * 只支持分享到对方账户相同地域。
        /// * 仅支持分享数据盘快照。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsSharePermissionRequest"/></param>
        /// <returns><see cref="ModifySnapshotsSharePermissionResponse"/></returns>
        public async Task<ModifySnapshotsSharePermissionResponse> ModifySnapshotsSharePermission(ModifySnapshotsSharePermissionRequest req)
        {
             JsonResponseModel<ModifySnapshotsSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotsSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotsSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifySnapshotsSharePermission接口的同步版本，本接口（ModifySnapshotsSharePermission）用于修改快照分享信息。
        /// 
        /// 分享快照后，被分享账户可以通过该快照创建云硬盘。
        /// * 每个快照最多可分享给50个账户。
        /// * 分享快照无法更改名称，描述，仅可用于创建云硬盘。
        /// * 只支持分享到对方账户相同地域。
        /// * 仅支持分享数据盘快照。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySnapshotsSharePermissionRequest"/></param>
        /// <returns>参考<see cref="ModifySnapshotsSharePermissionResponse"/>实例</returns>
        public ModifySnapshotsSharePermissionResponse ModifySnapshotsSharePermissionSync(ModifySnapshotsSharePermissionRequest req)
        {
             JsonResponseModel<ModifySnapshotsSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotsSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotsSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDisk）用于续费云硬盘。
        /// 
        /// * 只支持预付费的云硬盘。云硬盘类型可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中DiskChargeType字段解释。
        /// * 支持与挂载实例一起续费的场景，需要在[DiskChargePrepaid](/document/product/362/15669#DiskChargePrepaid)参数中指定CurInstanceDeadline，此时会按对齐到子机续费后的到期时间来续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDiskRequest"/></param>
        /// <returns><see cref="RenewDiskResponse"/></returns>
        public async Task<RenewDiskResponse> RenewDisk(RenewDiskRequest req)
        {
             JsonResponseModel<RenewDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewDisk接口的同步版本，本接口（RenewDisk）用于续费云硬盘。
        /// 
        /// * 只支持预付费的云硬盘。云硬盘类型可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中DiskChargeType字段解释。
        /// * 支持与挂载实例一起续费的场景，需要在[DiskChargePrepaid](/document/product/362/15669#DiskChargePrepaid)参数中指定CurInstanceDeadline，此时会按对齐到子机续费后的到期时间来续费。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDiskRequest"/></param>
        /// <returns>参考<see cref="RenewDiskResponse"/>实例</returns>
        public RenewDiskResponse RenewDiskSync(RenewDiskRequest req)
        {
             JsonResponseModel<RenewDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResizeDisk）用于扩容云硬盘。
        /// 
        /// * 只支持扩容弹性云盘。云硬盘类型可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中Portable字段解释。随云主机创建的云硬盘需通过[ResizeInstanceDisks](/document/product/213/15731)接口扩容。
        /// * 本接口为异步接口，接口成功返回时，云盘并未立即扩容到指定大小，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态为“EXPANDING”，表示正在扩容中，当状态变为“UNATTACHED”，表示扩容完成。 
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public async Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResizeDisk接口的同步版本，本接口（ResizeDisk）用于扩容云硬盘。
        /// 
        /// * 只支持扩容弹性云盘。云硬盘类型可以通过[DescribeDisks](/document/product/362/16315)接口查询，见输出参数中Portable字段解释。随云主机创建的云硬盘需通过[ResizeInstanceDisks](/document/product/213/15731)接口扩容。
        /// * 本接口为异步接口，接口成功返回时，云盘并未立即扩容到指定大小，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态为“EXPANDING”，表示正在扩容中，当状态变为“UNATTACHED”，表示扩容完成。 
        /// </summary>
        /// <param name="req">参考<see cref="ResizeDiskRequest"/></param>
        /// <returns>参考<see cref="ResizeDiskResponse"/>实例</returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于退还云硬盘。
        /// 
        /// * 不再使用的云盘，可通过本接口主动退还。
        /// * 本接口支持退还预付费云盘和按小时后付费云盘。按小时后付费云盘可直接退还，预付费云盘需符合退还规则。
        /// * 支持批量操作，每次请求批量云硬盘的上限为50。如果批量云盘存在不允许操作的，请求会以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public async Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TerminateDisks接口的同步版本，本接口（TerminateDisks）用于退还云硬盘。
        /// 
        /// * 不再使用的云盘，可通过本接口主动退还。
        /// * 本接口支持退还预付费云盘和按小时后付费云盘。按小时后付费云盘可直接退还，预付费云盘需符合退还规则。
        /// * 支持批量操作，每次请求批量云硬盘的上限为50。如果批量云盘存在不允许操作的，请求会以特定错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateDisksRequest"/></param>
        /// <returns>参考<see cref="TerminateDisksResponse"/>实例</returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnbindAutoSnapshotPolicy）用于解除云硬盘绑定的定期快照策略。
        /// 
        /// * 支持批量操作，可一次解除多个云盘与同一定期快照策略的绑定。 
        /// * 如果传入的云盘未绑定到当前定期快照策略，接口将自动跳过，仅解绑与当前定期快照策略绑定的云盘。
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public async Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindAutoSnapshotPolicy接口的同步版本，本接口（UnbindAutoSnapshotPolicy）用于解除云硬盘绑定的定期快照策略。
        /// 
        /// * 支持批量操作，可一次解除多个云盘与同一定期快照策略的绑定。 
        /// * 如果传入的云盘未绑定到当前定期快照策略，接口将自动跳过，仅解绑与当前定期快照策略绑定的云盘。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns>参考<see cref="UnbindAutoSnapshotPolicyResponse"/>实例</returns>
        public UnbindAutoSnapshotPolicyResponse UnbindAutoSnapshotPolicySync(UnbindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
